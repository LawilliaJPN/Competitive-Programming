package main
import (
    "bufio"
    "fmt"
    "os"
    "sort"
    "strconv"
)

func main() {
    n, k := readInt(), readInt()
    h := readIntSlice(n)
  
    answer := 0
    if n > k {
        sort.Ints(h)
        answer = sum(h[:n-k])
    }
    fmt.Println(answer)
}

var (
    sc = bufio.NewScanner(os.Stdin)
)

func init() {
    sc.Split(bufio.ScanWords)
}

func read() string {
    sc.Scan()
    return sc.Text()
}

func readInt() int {
    n, error := strconv.Atoi(read())
    if error != nil {
        panic(error)
    }
    return n
}

func readIntSlice(len int) []int {
    nSlice := make([]int, len)
    for i := range nSlice {
        nSlice[i] = readInt()
    }
    return nSlice
}

func sum(nSlice []int) int {
    var sum int
    for i := range nSlice {
        sum += nSlice[i]
    }
    return sum
}
