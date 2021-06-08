package main
import "fmt"


func main() {
    
    var f float64

         fmt.Println("Enter a float value : ")
         _, err := fmt.Scanf("%f", &f)

         if err != nil {
            fmt.Println("not number")
         }
         
    sum := f*100
    var counter int
    counter = 0
    	for sum >= 25 {
    		counter += 1
    		sum += -25
    	}
    	for sum >= 10 {
    		counter += 1
    		sum += -10
    	}
    	for sum >= 5 {
    		counter += 1
    		sum += -5
    	}
    	for sum >= 1 {
    		counter += 1
    		sum += -1
    	}
    	
    	fmt.Println(counter)

}
