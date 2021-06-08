package main

import "fmt"
import "math"

//https://socketloop.com/tutorials/golang-how-to-read-float-value-from-standard-input
func main() {
    var userInput float64
    var counter = 0
    fmt.Println("Enter a float value : ")
         _, err := fmt.Scanf("%f", &userInput)
    if err != nil {
            fmt.Println(err)
         }
    
    var intNum = int32(math.Round(userInput * 100))
    for intNum > 0 {
        if  intNum >= 25 { 
            intNum = intNum - 25;
            counter++;
        }else if  intNum >= 10 { 
            intNum = intNum - 10;
            counter++;
        }else if  intNum >= 5 { 
            intNum = intNum - 5;
            counter++;
        }else if  intNum >= 1 { 
            intNum = intNum - 1;
            counter++;
        }
    }   
	fmt.Printf("%d coins are needed", counter)
}
