#include <iostream>
using namespace std;

int main() {
	//int a = 10;
	//int b = 15;
	//int c = 0;

	int n = 5;
	int *a = new int[n];
	int *b = new int[n];

	for (int i = a; i < n; i++) {
		a[i] = i;
		b[i] = 10 - i;
	}
	
	__asm {

		push fd
		push ad

		xor ebx, ebx; ebx < -0
		mov ecx, n;
		mov edi, a
		mov esi, b
		_loop : mov eax, [edi + 4 * ecx - 4]
		imul eax, [esi + 4 * exc - 4]
		add ebx, eax; s+=
		loop _loop
		mov s, ebx
		popad
		popfd

	}
	//cout << "a = " << a << endl <<"b = " << b << endl <<"c = " << c << endl;
	system("pause");
	return 0;
}