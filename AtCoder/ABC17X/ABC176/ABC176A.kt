fun main(args: Array<String>) {
    val input = readLine()!!.split(" ").map(String::toInt)
    val n = input[0]
    val x = input[1]
    val t = input[2]

    val answer = (n + x - 1) / x * t
    println(answer)
}