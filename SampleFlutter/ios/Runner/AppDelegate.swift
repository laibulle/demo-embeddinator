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
           
           DispatchQueue.global(qos: .background).async {
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
           }
    
    return super.application(application, didFinishLaunchingWithOptions: launchOptions)
  }
}
