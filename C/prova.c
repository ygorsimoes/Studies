#include <stdio.h>

int quant = -1, pos;
float Lista[46], num;

int main() {
    return 0;
}

void inserir_elemento_posicao() {
    if (quant == 4) {
        printf("Lista Cheia!");
    } else {
        printf("Informe o elemento: ");
        scanf("%f", &num);
        printf("Informe a posição em que deseja inserir o elemento: ");
        scanf("%d", &pos);
        if (pos < 0 || pos > 45) {
            printf("Posição Inválida!");
        } else {
            for (int i = quant + 1; i > pos; i--) {
                Lista[i] = Lista[i - 1];
            }
            quant++;
            Lista[pos] = num;
            printf("“Elemento %0.2f foi inserido na posição %d com sucesso!", num, pos);
        }
    }
}

void ordenar_bublesort() {
    int j, aux;
    if (quant == -1) {
        printf("Lista vazia!");
    } else {
        for (int i = 0; i < quant; ++i) {
            for (j = 0; j < quant; ++j) {
                if (Lista[j] > Lista[j + 1]) {
                    aux = Lista[j];
                    Lista[j] = Lista[j + 1];
                    Lista[j + 1] = aux;
                }
            }
        }
        printf("“Ordenação realizada com sucesso!")
    }
}

//void remover_elemento() {
//    if (quant == -1) {
//        printf("Lista Vazia!");
//    } else {
//        printf("Informe o elemento a ser removido: ");
//        scanf("%f", &num);
//        pos = -1;
//        for (int i = 0; i < quant; ++i) {
//            if (Lista[i] == num) {
//                pos = 1;
//            }
//            if (pos != -1) {
//                for (int i = 0; i < quant; ++i) {
//                    Lista[i] = Lista[i + 1];
//                }
//                quant--;
//                printf("“Elemento %0.2f foi removido da posição %d com sucesso!", num, pos);
//            } else {
//                printf("Elemento %0.2f não foi encontrado!", num);
//            }
//        }
//    }
//}
//

void busca_binaria() {
    int inicio, fim;
    if (quant == -1) {
        printf("Lista Vazia!");
    } else {
        ordenar_bublesort();
        printf("Informe o elemento a ser buscado: ");
        scanf("%f", &num);
        achou = 0;
        inicio = 0;
        fim = quant;
        pos = (inicio + fim)/2;
        while (achou == 0 && inicio <= fim) {
            if (num == Lista[pos]) {
                achou = 1;
            } else {
                if (num > Lista[pos]) {
                    inicio = pos + 1;
                } else {
                    fim = pos - 1;
                }
                pos = (inicio + fim)/2;
            }
        }
        if (achou == 0) {
            printf("Elemento %0.2f não foi encontrado na lista!", num)
        } else {
            printf("“Elemento %0.2f foi encontrado na posição %d da lista!", num, pos);
        }
    }
}