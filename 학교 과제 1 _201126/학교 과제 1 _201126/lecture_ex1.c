#include <stdio.h>
#include <stdlib.h>

struct Book {
	int number;
	char title[30];
};

int main(void)
{
	int a = 0;
	struct Book* p;
	struct Book2*[5];

	p = (struct Book*)malloc(2 * sizeof(struct Book));

	if (p == NULL) {
		printf("메모리 할당 오류\n");
		exit(1);
	}

	p->number = 1;
	strcpy(p->title, "C Programming");

	(p + 1)->number = 2;
	strcpy((p + 1)->title, "Data Structure");

	printf("\nPointer Processing.....");
	for (a = 0; a < 2; a++) {
		printf("\nStructure Book of %d : %s", (p + a)->number, (p + a)->title);
	}

	printf("\nArray Processing.....");
	for (a = 0; a < 2; a++) {
		printf("\nStructure Book of %d : %s", p[a].number, p[a].title);
	}

	free(p);

	return 0;
}