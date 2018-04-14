#include <sys/socket.h>
#include <stdio.h>
#include <netinet/in.h>
#include <string.h>
#include <arpa/inet.h>
#include <unistd.h>

int main(void) {
 char abcd[512];
 char wiadomosc[1024];
 struct sockaddr_in adr;
 unsigned int port;
 int gniazdo,num;
 
 printf("Podaj adres IP odbiorcy: ");
 scanf("%s", abcd);
 printf("Podaj numer portu odbiorcy: ");
 scanf("%u", &port);
 gniazdo = socket(PF_INET, SOCK_STREAM, 0);
 adr.sin_family = AF_INET;
 adr.sin_port = htons(port);
 adr.sin_addr.s_addr = inet_addr(abcd);
 if (connect(gniazdo, (struct sockaddr*) &adr,
 sizeof(adr)) < 0) 
 {
 printf("Nawiazanie polaczenia nie powiodlo sie.\n");
 return 1;
 }
 printf("Polaczenie nawiazane.\n ");
while (1==1)
{
 printf("Podaj wiadomosc: ");
 fflush(stdout); fgetc(stdin);
 fgets(wiadomosc, 1024, stdin);
 send(gniazdo, wiadomosc, strlen(wiadomosc), 0);
 printf("Tresc wiadomosci: %s\n",wiadomosc);
 printf("Succes\n");

num = recv(gniazdo,wiadomosc, sizeof(wiadomosc),0);
if(num <= 0 )
{
	printf("Blad");
	break;
}
printf("Z servera: %s\n", wiadomosc);
}
 close(gniazdo);
 return 0;
}
