package main
import "fmt"

func main() {
    
    fmt.Println("How much dollars do you have?: ")
    var cash float32
    var counter int
    counter = 0
    fmt.Scan(&cash)
   
  
    temp := (int)(cash * 100)

    for temp >= 25 {
		temp = temp - 25
        counter = counter + 1
	}

    for temp >= 10 {
		temp = temp - 10
        counter = counter + 1
	}

    for temp >= 5 {
		temp = temp - 5
        counter = counter + 1
	}

    for temp >= 1 {
		temp = temp - 1
        counter = counter + 1
	}
    
    fmt.Println("That's your coins count:")
    fmt.Println(counter)
}
