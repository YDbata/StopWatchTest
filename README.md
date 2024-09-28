# StopWatchTest
C# StopWatch정리

```C#
StopWatch sw = new StopWatch();
// 시간 측정 시작
sw.Start();

// 시간 측정 일시 중지
sw.Stop();

// 측정된 시간 리셋
sw.Reset();

// 측정된 시간을 리셋하고 바로 재시작
sw.Restart();

// 시간을 측정 중인지 확인
sw.IsRunning();

// 시간을 ms까지 반환하는 함수
// 00:00:00 형태 --> mm:ss:ms 순
sw.Elapsed;

// 시간을 ms 4자리만 반환
sw.ElapsedMilliseconds;

// ms 8자리
sw.ElapsedTicks;


sw.Elapsed.Days; // 측정된 일수
sw.Elapsed.Hours; // 시간
sw.Elapsed.Minutes; // 분
sw.Elapsed.Seconds; // 초


// 측정된 시간을 day를 1로 봤을 때 숫자로 환산
sw.Elapsed.TotalDays;
sw.Elapsed.TotalHours; // 시간으로 환산
sw.Elapsed.TotalMinutes; //분으로 환산
sw.Elapsed.TotalSeconds; //초로 환산


// Equals를 이용하여 현재 지난 시간과 같으면 True를 얻을 수 있다.
// 현재 5초가 지났을 때
sw.Elapsed.Seconds.Equals(5);

```
