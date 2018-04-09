using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApp2
{
  /// <summary>
  /// MainWindow.xaml の相互作用ロジック
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      this.datagrid1.ItemsSource = new[]
      {
        new DeviceInfo { Device_id = 111, Device_name = "name111" },
        new DeviceInfo { Device_id = 222, Device_name = "name222" }
      };
      /*
            this.datagrid2.ItemsSource = new[]
            {
              new DeviceInfo { Device_id = 111, Device_name = "name111" },
              new DeviceInfo { Device_id = 222, Device_name = "name222" }
            };
      */

      // dinfoはDeviceInfo2のList
      var dinfo = new List<DeviceInfo2>();

      // deviceInfoはDeviceInfo2のインスタンス
      var deviceInfo = new DeviceInfo2();

      //deviceInfo = new DeviceInfo2();
      // インスタンスを作って追加
      deviceInfo.PortName = "COM1";
      deviceInfo.DeviceID = "1710003";
      deviceInfo.DownLoad = 80;
      deviceInfo.UpLoad = 20;
      dinfo.Add(deviceInfo);

      // インスタンスを作って追加
      deviceInfo = new DeviceInfo2();
      deviceInfo.PortName = "COM3";
      deviceInfo.DeviceID = "1710004";
      deviceInfo.DownLoad = 50;
      deviceInfo.UpLoad = 10;
      dinfo.Add(deviceInfo);

      this.datagrid2.ItemsSource = dinfo;

      // DataGridにプログレスバーの表示までできたけど、更新てできるの？

      Console.WriteLine("----- {0}", dinfo[0].DownLoad);
      // なんだろ、例えばモジュールIDとかで検索して、進捗を更新すればいいってこと？
      // LINQで簡単に検索できるの？


    }
  }

  public class DeviceInfo
  {
    public int Device_id { get; set; }
    public string Device_name { get; set; }
  }

  public class DeviceInfo2
  {
    public string PortName { get; set; }
    public string DeviceID { get; set; }
    public int DownLoad { get; set; }
    public int UpLoad { get; set; }
  }


}
