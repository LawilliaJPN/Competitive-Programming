fun main(args: Array<String>) {
    val k = readLine()!!.toInt()
    val input = readLine()!!.split(" ").map(String::toInt)
    val a = input[0]
    val b = input[1]

    var answer = "NG"
    for (i in a..b) if (i % k == 0) answer = "OK"
    println(answer)
}