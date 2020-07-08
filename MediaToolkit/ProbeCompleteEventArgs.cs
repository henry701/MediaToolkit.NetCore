using System;

namespace MediaToolkit
{
  public class ProbeCompleteEventArgs : EventArgs
  {
    /// <summary>
    /// Raises notification once probing is complete
    /// </summary>
    /// <param name="totalDuration">The total duration of the original media</param>
    /// <param name="frames">The amount of frames in the media</param>
    /// <param name="fps">The frames probed per second</param>
    /// <param name="sizeKb">The current size in Kb of the probed media</param>
    /// <param name="bitrate">The bit rate of the probed media</param>
    /// <param name="width">The width of the media</param>
    /// <param name="height">The height of the media</param>
    public ProbeCompleteEventArgs(TimeSpan totalDuration, long? frames, double? fps, int? sizeKb, double? bitrate, int? width, int? height)
    {
      TotalDuration = totalDuration;
      Frames = frames;
      Fps = fps;
      SizeKb = sizeKb;
      Bitrate = bitrate;
      Width = width;
      Height = height;
    }

    public long? Frames { get; private set; }
    public double? Fps { get; private set; }
    public int? SizeKb { get; private set; }
    public double? Bitrate { get; private set; }
    public TimeSpan TotalDuration { get; internal set; }
    public int? Width { get; private set; }
    public int? Height { get; private set; }
  }
}
