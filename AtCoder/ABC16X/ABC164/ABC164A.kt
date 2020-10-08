fun main(args: Array<String>) {
    val input = readLine()!!.split(" ").map(String::toInt)
    val s = input[0]
    val w = input[1]

    val answer = if (s > w) "safe" else "unsafe"
    println(answer)
}