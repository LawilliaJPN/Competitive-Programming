fun main(args: Array<String>) {
    val input = readLine()!!.split(" ").map(String::toDouble)
    val d = input[0]
    val t = input[1]
    val s = input[2]

    val answer = if (d / s <= t) "Yes" else "No"
    println(answer)
}