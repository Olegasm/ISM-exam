package main
import "fmt"

func main() {
    var string float32
    
    fmt.Println("Enter a number: ")
  
    fmt.Scanln(&string)
    
    var cents = (int)(string * 100)
    
    var coins int

    coins = 0
    
    
    for cents >= 25 {
        coins++
        cents = cents - 25
    }
    for cents >= 10 {
        coins++
        cents = cents - 10
    }
    for cents >= 5 {
        coins++
        cents = cents - 5
    }
    for cents >= 1 {
        coins++
        cents = cents - 1
    }
    fmt.Println("Minimum number of coins required: ")
    fmt.Println(coins)
}
