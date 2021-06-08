/******************************************************************************
Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
package main
import "fmt"

func main() {
    var coinsCount int

    var userInput float64

    fmt.Scanln(&userInput)
   
    var coins int = int(userInput*100)

    for coins >= 25 {
        coins = coins - 25
        coinsCount = coinsCount + 1
    }
    for coins >= 10 {
        coins = coins - 10
        coinsCount = coinsCount + 1
    }
    for coins >= 5 {
        coins = coins - 5
        coinsCount = coinsCount + 1
    }
    for coins >= 1 {
        coins = coins - 1
        coinsCount = coinsCount + 1
    }
    
    fmt.Println(coinsCount)
}
