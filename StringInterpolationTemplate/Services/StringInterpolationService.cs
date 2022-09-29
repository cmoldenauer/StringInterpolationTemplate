using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        return $"{_date.Now:yyyy.MM.dd}";
    }

    public string Number03()
    {
        var date = _date.Now.ToString("dd");
        var date2 = _date.Now.ToString("MMMM, yyyy");
        var answer = $"Day {date} of {date2}";
        return answer;
    }

    public string Number04()
    {
        return $"Year: {_date.Now:yyyy}, Month: {_date.Now:MM}, Day: {_date.Now:dd}";
    }

    public string Number05()
    {
        return $"{_date.Now,10:dddd}";
    }

    public string Number06()
    {
        return $"{_date.Now,10:hh:mm tt}{_date.Now,10:dddd}";
    }

    public string Number07()
    {
        return $"h:{_date.Now:hh}, m:{_date.Now:mm}, s:{_date.Now:ss}";
    }

    public string Number08()
    {
        return $"{_date.Now:yyyy.MM.dd.hh.mm.ss}";
    }

    public string Number09()
    {
        return $"{Math.PI:C}";
    }

    public string Number10()
    {
        return $"{Math.PI,10:n3}";
    }

    public string Number11()
    {
        throw new NotImplementedException();
    }

    //2.2019.01.22
}
