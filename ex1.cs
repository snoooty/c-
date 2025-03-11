using System;
//  using : 사용하겠다.
/*  System : C# 코드가 기본적으로 필요로 하는 클래스를 담고있음
    즉, namespace안에 있는 클래스를 사용하겠다고 컴파일러에게 알리는 역할
    
    -컴파일러 : 프로그래밍 언어를 기계어로 변환하는 소프트웨어 도구
*/

using DataNamespace;
/*  Namespace 에 접근하기 위한 선언
    이를 선언해야 클래스에 접근가능
*/

class ex1{


    public static void Main(){
        //  코멘트는 이렇게 작성
        /*  복수 작성할때는 이렇게
            할수있다.
        */
        //  추가
        Console.WriteLine("Hellow world");
        Console.WriteLine("Hellow c#");
        Console.WriteLine(System.DateTime.Now);
        String ck = "check";
        Console.WriteLine(ck);

        for(int i = 0; i < 5; i++){
            Console.WriteLine(i);
        }
        

        bool f = false;

        Console.WriteLine(f);

        f = true;

        Console.WriteLine(f);

        f = false;

        ex_boolean ex_b = new ex_boolean(f);
        ex_b.ex_bb(f);

        Console.WriteLine(f);
        
        
        
        
    }
}