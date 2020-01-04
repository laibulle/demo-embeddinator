import UIKit
import Flutter

@UIApplicationMain
@objc class AppDelegate: FlutterAppDelegate {
  override func application(
    _ application: UIApplication,
    didFinishLaunchingWithOptions launchOptions: [UIApplication.LaunchOptionsKey: Any]?
  ) -> Bool {
    GeneratedPluginRegistrant.register(with: self)
    let gret = Greeter()
           
           /*DispatchQueue.global(qos: .background).async {
               print(gret?.greet())
           }
           
           DispatchQueue.global(qos: .background).async {
               var prevCount = 0
               while (gret?.isFinished() == false) {
                   usleep(100000) //will sleep for 0.1 second
                   let persones = gret?.getPersones()
                   if(persones?.count != prevCount) {
                       print(persones)
                       prevCount = persones!.count
                   }
               }
           }*/
    
    let controller : FlutterViewController = window?.rootViewController as! FlutterViewController
    let personChannel = FlutterMethodChannel(name: "samples.flutter.dev/battery",
                                              binaryMessenger: controller.binaryMessenger)
    personChannel.setMethodCallHandler({
      (call: FlutterMethodCall, result: @escaping FlutterResult) -> Void in
        
        guard call.method == "getBatteryLevel" else {
          result(FlutterMethodNotImplemented)
          return
        }
        
        DispatchQueue.global(qos: .background).async {
            let count = gret?.greet().count
            result(Int(4))
            //print(gret?.greet())
        }
                  
        DispatchQueue.global(qos: .background).async {
            var prevCount = 0
            while (gret?.isFinished() == false) {
                usleep(100000) //will sleep for 0.1 second
                let persones = gret?.getPersones()
                if(persones?.count != prevCount) {
                    print(persones)
                    prevCount = persones!.count
                }
            }
        }
        
      // Note: this method is invoked on the UI thread.
      // Handle battery messages.
    })
    
    return super.application(application, didFinishLaunchingWithOptions: launchOptions)
  }
}
