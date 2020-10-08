import kotlin.math.*

fun main(args: Array<String>) {
    val a = readLine()!!.toDouble()

    val answer = (a + a.pow(2) + a.pow(3)).toInt()
    println(answer)
}