#include <sys/types.h>
#include <sys/socket.h>
#include <stdio.h>
#include <netinet/in.h>
#include <string.h>
#include <arpa/inet.h>
#include <unistd.h>
#include <stdlib.h>
#include<sys/wait.h>


int main(void) {
//delkaracja zmiennych
 unsigned int port;
 char bufor[1024];
 int gniazdo, gniazdo2,nowegniazdo;
 struct sockaddr_in adr, nadawca;
 socklen_t dl = sizeof(struct sockaddr_in);
 char wiadomosc[1024];
int clients[2];
int i,s;
i=0;
s=0;
 int n,pid;
size_t iloscclientow;


// Czesc odpowowiadajaca za sam server
 printf("Na ktorym porcie mam sluchac? : ");
 scanf("%u", &port);
 gniazdo = socket(PF_INET, SOCK_STREAM, 0);
 adr.sin_family = AF_INET;
 adr.sin_port = htons(port);
 adr.sin_addr.s_addr = INADDR_ANY;
 if (bind(gniazdo, (struct sockaddr*) &adr, 
 sizeof(adr)) < 0) {
 printf("Bind nie powiodl sie.\n");
 return 1;
 }
 if (listen(gniazdo, 10) < 0) {
 printf("Listen nie powiodl sie.\n");
 return 1; 
 }

 //laczenie z klientami
 printf("Czekam na polaczenie ...\n");
 while (i<2) 
 {
	nowegniazdo = accept(gniazdo, (struct sockaddr*) &nadawca,&dl);
	clients[i] = nowegniazdo;
	
	if (nowegniazdo < 0)
	{
		perror("Error na akcept");
		exit(1);
	}
	printf("Klient nr: %d, polaczony.\n",clients[i]);
	i++;
// forkowanie
 }
printf("polaczeni z serverem.\n");
i=0;
while(1)
{
		pid=fork();
		if (pid<0)
		{
			perror("Error z frokiem");
		}
		if (pid == 0)
		{
				close(gniazdo);
				 memset(bufor, 0, 1024);
				 recv(clients[i], bufor, 1024, 0);
				 printf("Wiadomosc od %s: %s\n",
				 inet_ntoa(nadawca.sin_addr),
				 bufor);
				if (i == 0)
				{
					 if ((send(clients[i+1],bufor, strlen(bufor),0))== -1) 
					 {
					                     fprintf(stderr, "Failure Sending Message for client %d\n",clients[i+1]);
								printf("Buffor: %s",bufor);
					                     close(clients[i+1]);
					                     break;
			          	 }
					printf("Wiadomosc wyslana: %s\nNumber of bytes sent: %d\n",bufor,
			 		strlen(bufor));
				 }
				else
				{
					if ((send(clients[i-1],bufor, strlen(bufor),0))== -1) 
					 {
					                     fprintf(stderr, "Failure Sending Message for client %d\n",clients[i-1]);
								printf("Buffor: %s",bufor);
					                     close(clients[i-1]);
					                     break;
			          	 }
					printf("Wiadomosc wyslana: %s\nNumber of bytes sent: %d\n",bufor,
			 		strlen(bufor));
				}
				exit(0);
		}
		else
		{
			wait(NULL);
	 		//close(nowegniazdo);
		}
		i++;
		if(i>1)
		{
			i=0;
		}

}
 close(gniazdo); 
 return 0; 
}
