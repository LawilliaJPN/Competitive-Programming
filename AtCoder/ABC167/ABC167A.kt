fun main(args: Array<String>) {
    val s = readLine()!!
    val t = readLine()!!
    val answer = if (s == t.substring(0, s.length)) "Yes" else "No"
    println(answer)
}