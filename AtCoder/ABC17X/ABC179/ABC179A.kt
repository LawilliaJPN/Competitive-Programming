fun main(args: Array<String>) {
    val s = readLine()!!
    val answer = if (s.takeLast(1) == "s") (s + "es") else (s + "s")
    println(answer)
}