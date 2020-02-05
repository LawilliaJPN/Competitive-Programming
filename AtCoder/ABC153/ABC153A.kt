fun main(args: Array<String>) {
    val inputs = readLine()!!.split(" ").map(String::toDouble)
    println(Math.ceil(inputs[0] / inputs[1]).toInt())
}
