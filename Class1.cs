#include <iostream>
#include<cmath>
#include <iostream>

using namespace std;

namespace PQL
{
    void function1()
    {
        int n;
        cout << "n=";
        cin >> n;
        if (n < 0)
            cout << "注意负数！" << endl;
        cout << n << endl;
    }

    void function2()
    {
        int n;
        cin >> n;
        if (n % 2 == 0)
        {
            cout << n << "是偶数" << endl;

        }
        else
        {
            cout << n << "是奇数" << endl;
        }
    }

    void function3()
    {
        int m;
        cout << "m=";
        cin >> m;
        if (m >= 80) cout << "非常欢迎你参加音乐社";
        else cout << "欢迎你参加音乐社";
    }
    void function4()
    {
        int cup;
        float a, b;
        cout << "cup=";
        cin >> cup;
        a = 0.9;
        b = 1.0 * cup / (cup + cup / 8);
        if (a < b) cout << "大洋商城" << endl;
        else cout << "百汇商厦" << endl;
    }

    void function5()
    {
        int money;
        cout << "money=";
        cin >> money;
        if (money < 100000) cout << "梨树=" << money / 500 << "棵" << endl;
        else
        {
            cout << "梨树" << floor(money * 0.3 / 500) << "棵" << endl;
            cout << "桃树" << floor(money * 0.5 / 600) << "棵" << endl;
            cout << "苹果树" << floor(money * 0.2 / 800) << "棵" << endl;
        }
    }
}

int main()
{
    int item;
    cout << "请输入你要选择的函数，如果是第61页的题，请输入61(61 62 63 64 65)" << endl;
    std::cin >> item;
    switch (item)
    {
        case 61: PQL::function1(); break;
        case 62: PQL::function2(); break;
        case 63: PQL::function3(); break;
        case 64: PQL::function4(); break;
        case 65: PQL::function5(); break;
    }


    return 0;
}
