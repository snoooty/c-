using System;
// using : 사용하겠다.
/* System : C# 코드가 기본적으로 필요로 하는 클래스를 담고있음
    즉, namespace안에 있는 클래스를 사용하겠다고 컴파일러에게 알리는 역할
    
    -컴파일러 : 프로그래밍 언어를 기계어로 변환하는 소프트웨어 도구
*/

class ex1{
    public static void Main(){
        // 코멘트는 이렇게 작성
        /* 복수 작성할때는 이렇게

        할수있다.
        */
        // 추가
        Console.WriteLine("Hellow world");
        Console.WriteLine("Hellow c#");
        Console.WriteLine(System.DateTime.Now);

        for(int i = 0; i < 5; i++){
            Console.WriteLine(i);
        }
    }
}