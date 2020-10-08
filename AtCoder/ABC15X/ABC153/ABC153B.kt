fun main(args: Array<String>) {
    val h = readLine()!!.split(" ").map(String::toInt)[0]
    val a = readLine()!!.split(" ").map(String::toInt)

    val answer = if (a.sum() >= h) "Yes" else "No"
    println(answer)    
}
