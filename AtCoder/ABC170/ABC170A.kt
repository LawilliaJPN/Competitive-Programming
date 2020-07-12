fun main(args: Array<String>) {
    val x = readLine()!!.split(" ").map(String::toInt)
    println(x.indexOf(0) + 1);
}

/* •Ê‰ð
fun main(args: Array<String>) {
    when(readLine()!!) {
        "0 2 3 4 5" -> println("1")
        "1 0 3 4 5" -> println("2")
        "1 2 0 4 5" -> println("3")
        "1 2 3 0 5" -> println("4")
        "1 2 3 4 0" -> println("5")
    }
}
*/