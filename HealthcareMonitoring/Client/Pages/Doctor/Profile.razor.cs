namespace HealthcareMonitoring.Client.Pages.Doctor;

public partial class Profile
{
    private string? _profileString;

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    protected override void OnInitialized()
    {
        base.OnInitialized();

        // TODO: 应该从数据库中获取医生的 Profile 信息赋值给变量即可
        _profileString = "<h1>我是医生</h1>";
    }

    private Task OnSaveProfileAsync(string profileString)
    {
        // TODO: 保存到数据库中
        return Task.CompletedTask;
    }
}