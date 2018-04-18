#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
 
#define PORT 11114
 
int main(int argc, char *argv[])
 {
    /*deklaracja zbiorow socketow*/
    fd_set glowny_fd_set, inne_fd_set;
    /*deklaracja adresu klienta i servera*/
    struct sockaddr_in adres_servera,adres_klienta;
    /* Deklaracja socketow oraz zmiennych pomocniczych*/
    int najwiekszy_fd, listener, nowy_fd, dl_adresu, wiadomosc, i, j;
    /*deklaracja bufora wiadomosci*/
    char buf[1000000];
    int yes=1;
   
    /*Wyzerowanie zbiorow*/
    FD_ZERO(&glowny_fd_set);
    FD_ZERO(&inne_fd_set);
   
    /*uruchamianie socketowanie servera*/
    if((listener = socket(AF_INET, SOCK_STREAM, 0)) == -1)
    {
        perror("Socketowanie servera nie powiodlo sie");
        exit(1);
    }
    else
    {
        printf("Socketowanie servera udane\n");
    }
    /*ustawianie servera*/
    if (setsockopt(listener, SOL_SOCKET, SO_REUSEADDR, &yes, sizeof(int)) == -1)
    {
        perror("Ustawianie socketa-servera nie wyszlo");
        exit(1);
    }
    else
    {
        printf("Server socket gotowy\n");
    }
 
    adres_servera.sin_family = AF_INET;
    adres_servera.sin_addr.s_addr = INADDR_ANY;
    adres_servera.sin_port = htons(PORT);
   
    /*Cyzszczenie adresu servera*/
    memset(&(adres_servera.sin_zero), '\0', 8);
    /*Bindowanie servera*/
    if (bind(listener,(struct sockaddr *)&adres_servera,sizeof(adres_servera)) == -1)
    {
        perror("Bind servera nieudany");
        exit(1);
    }
    else
    {
        printf("Bindowanie udane\n");
    }
    /*zamarkowanie servera aby odbierał*/
    if(listen(listener,10) == -1)
    {
        perror("LIsten servera nieudany");
        exit(1);
    }
    else
    {
        printf("Listen servera udany\n");
    }
    /*Dodanie do glowny_fd_set serera*/
    FD_SET(listener, &glowny_fd_set);
   
    najwiekszy_fd = listener;
 
 
    for(;;)
    {
       
        inne_fd_set = glowny_fd_set;
        /*Zaczynanie select()*/
        if(select(najwiekszy_fd + 1, &inne_fd_set, NULL, NULL, NULL) == -1)
        {
            perror("Nieudany select()");
            exit(1);
        }
 
        printf("select() udany\n");
       
        for(i=0;i<=najwiekszy_fd;i++)
        {
            /*sprawdza czy i jest czescia inne_fd_set*/
            if(FD_ISSET(i,&inne_fd_set))
            {
                /*jesli i to server*/
                if(i == listener)
                {
                    dl_adresu = sizeof(adres_klienta);
                    /*akceptowanie klienta*/
                    if ((nowy_fd = accept(listener,(struct sockaddr *)&adres_klienta, &dl_adresu))==-1)
                    {
                        perror("Brak akceptacji");
                    }
                    else
                    {
                        printf("Zaakceptowane\n");
                        printf("Wielkosc najnowszego deskryptora: %d\n",nowy_fd);
                        /*dodanie nowego klienta do glowny_fd_set*/
                        FD_SET(nowy_fd, &glowny_fd_set);
 
                        printf("Wielkosc najwiekszego deskryptora: %d\n",najwiekszy_fd);
                        printf("Wielkosc najnowszego deskryptora: %d\n",nowy_fd);
 
                        if(nowy_fd > najwiekszy_fd)
                        {
                            /*podąża za iloscia klientow*/
                            najwiekszy_fd = nowy_fd;
                        }
                        printf("Nowe polaczenie od %s na sockecie %d\n", inet_ntoa(adres_klienta.sin_addr),nowy_fd);
                    }
                }
                else
                {
                    /*dostanie wiadomosci*/
                    if((wiadomosc = recv(i,buf,sizeof(buf),0))  <= 0)
                    {
                        if(wiadomosc == 0)
                            printf("Klient %d sie rozloczyl.\n",i);
                   
                        else
                            perror("Blad odbioru wiadomosci\n");
                       
                        /*czysci klienta i jego socket*/
                        close(i);
                        FD_CLR(i,&glowny_fd_set);
                    }
                    else
                    {
                        /*Wysylanie do pozostalych klientow*/
                        for(j=0;j<=najwiekszy_fd; j++)
                        {
                            if(FD_ISSET(j,&glowny_fd_set))
                            {
                                if(j != listener && j != i)
                                {
                                    if(send(j,buf,wiadomosc,0) == -1)
                                        perror("Send nieudany");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
return 0;
}