#include<iostream>

using namespace std;

int main()  {
    
    int A;
    bool isPrime = true;

    cin >> A;

    for(int i = 2; i * i <= A; i++)
    {
        if (A % i == 0)
        {
            isPrime = false;
            cout << "NO" << endl;
            break;
        }
    }

    if (isPrime)
    {
        cout << "YES" << endl;
    }
    
    return 0;
}