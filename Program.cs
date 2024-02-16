#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define MAX_TRIES 5
#define MAX_WORD_LEN 20

int main()
{
    char word[MAX_WORD_LEN];
    char guessed[MAX_WORD_LEN];
    int tries = 0;
    int word_len;
    int i, found, win;

    printf("Bienvenido al juego del ahorcado!\n");
    printf("Ingrese la palabra a adivinar (sin espacios y en minúsculas): ");
    scanf("%s", word);

    word_len = strlen(word);
    for (i = 0; i < word_len; i++)
        guessed[i] = '_';
    guessed[word_len] = '\0';

    while (tries < MAX_TRIES)
    {
        printf("\nPalabra a adivinar: %s\n", guessed);
        printf("Intentos restantes: %d\n", MAX_TRIES - tries);
        printf("Ingrese una letra: ");
        char guess;
        scanf(" %c", &guess); // %c no consume los espacios en blanco, así que el espacio antes de %c es importante.

        found = 0;
        for (i = 0; i < word_len; i++)
        {
            if (word[i] == guess)
            {
                guessed[i] = guess;
                found = 1;
            }
        }

        if (!found)
        {
            printf("La letra '%c' no está en la palabra.\n", guess);
            tries++;
        }

        win = 1;
        for (i = 0; i < word_len; i++)
        {
            if (guessed[i] == '_')
            {
                win = 0;
                break;
            }
        }

        if (win)
        {
            printf("\n¡Felicidades! Has adivinado la palabra: %s\n", guessed);
            return 0;
        }
    }

    printf("\n¡Has perdido! La palabra era: %s\n", word);
    return 0;
}
