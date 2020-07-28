fun main(args: Array<String>) {
    val n = readLine()!!.toInt()

    val answer = if (n % 1000 == 0) 0 else (1000 - n % 1000);
    println(answer)
}