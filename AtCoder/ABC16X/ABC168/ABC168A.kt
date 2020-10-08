fun main(args: Array<String>) {
    val n = readLine()!!.toInt()
    val reading = arrayOf("pon", "pon", "hon", "bon", "hon", "hon", "pon", "hon", "pon", "hon")
    println(reading[n%10])
}