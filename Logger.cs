//در نمیتونه کلاس دیگ ای ازش ارث بری کنه ولی خودش میتونه فرزند باشه 
sealed class Logger {
    public void Log(string message) {
        Console.WriteLine(message);
    }
}