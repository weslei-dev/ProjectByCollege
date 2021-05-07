#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL, "Portuguese");

    int ano;

    printf("descubra, se o ano que iras inseri, é um ano bisexto!\n");
    scanf("%d",&ano);

    if(ano%4 == 0)
        {
        printf("%d é um ano bisexto\n",ano);

    }
     else {
        printf("desculpa, %d não é um ano bisexto\n",&ano);
     }



    return 0;
}
