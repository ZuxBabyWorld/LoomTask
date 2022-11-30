using System;
using System.Threading.Tasks;

public class LoomTask
{
    /// <summary>
    /// 主线程异步运行
    /// </summary>
    /// <param name="action"></param>
    /// <returns></returns>
    static public async Task RunAsyncMain(Action action)
    {
        await Task.Delay(0);
        action?.Invoke();
    }

    /// <summary>
    /// 其他线程异步运行
    /// </summary>
    /// <param name="action"></param>
    /// <returns></returns>
    static public async Task RunAsync(Action action)
    {
        await Task.Run( () => {
            action?.Invoke();
        });
    }
}
