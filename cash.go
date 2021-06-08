/******************************************************************************
Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
package main
import "fmt"

func main() {
    
    var tf int = 25
    var te int = 10
    var fi int = 5
    var on int = 1

    // var for counting da coins
    var countCoins int

    // var then variable name then variable type, source: https://www.geeksforgeeks.org/how-to-take-input-from-the-user-in-golang/
    var change float64
    
    fmt.Println("Enter the change amount: ")
    fmt.Scanln(&change)
    
    // Taking input from user, source: https://www.geeksforgeeks.org/how-to-take-input-from-the-user-in-golang/
    // scr: https://programming.guide/go/do-while-loop.html
    
    var changeconv int = int(change*100)
    
    for changeconv - tf >= 0 {
        if changeconv == 0 {
            break
        }
        changeconv = changeconv - tf
		countCoins += 1 
	}
	
	for changeconv - te >= 0 {
        if changeconv == 0 {
            break
        }
        changeconv = changeconv - te
		countCoins += 1 
	}
	
	for changeconv - fi >= 0 {
        if changeconv == 0 {
            break
        }
        changeconv = changeconv - fi
		countCoins += 1 
	}
	
	for changeconv - on >= 0 {
        if changeconv == 0 {
            break
        }
        changeconv = changeconv - on
		countCoins += 1 
	}
	
    fmt.Println(countCoins)
}
