fun main(args: Array<String>) {
    when(readLine()!!) {
        "SRR", "RRS" -> println("2")
        "RRR" -> println("3")
        "SSS" -> println("0")
        else -> println("1")
    }
}