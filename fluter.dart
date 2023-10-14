import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        // This is the theme of your application.
        //
        // Try running your application with "flutter run". You'll see the
        // application has a blue toolbar. Then, without quitting the app, try
        // changing the primarySwatch below to Colors.green and then invoke
        // "hot reload" (press "r" in the console where you ran "flutter run",
        // or simply save your changes to "hot reload" in a Flutter IDE).
        // Notice that the counter didn't reset back to zero; the application
        // is not restarted.
        primarySwatch: Colors.blue,
      ),
      home: const MyHomePage(title: 'Flutter Demo Home Page'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key, required this.title});

  // This widget is the home page of your application. It is stateful, meaning
  // that it has a State object (defined below) that contains fields that affect
  // how it looks.

  // This class is the configuration for the state. It holds the values (in this
  // case the title) provided by the parent (in this case the App widget) and
  // used by the build method of the State. Fields in a Widget subclass are
  // always marked "final".

  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  int _counter = 0;

  void _incrementCounter() {
    setState(() {
      // This call to setState tells the Flutter framework that something has
      // changed in this State, which causes it to rerun the build method below
      // so that the display can reflect the updated values. If we changed
      // _counter without calling setState(), then the build method would not be
      // called again, and so nothing would appear to happen.
      _counter++;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Flutter Demo Scaffold"),
      ),
      body: const Center(
        child: Text(
          "Demo Scaffold!!!",
          style: TextStyle(
            color: Colors.black,
            fontSize: 40.0,
          ),
        )
      ),
      floatingActionButton: FloatingActionButton(
        elevation: 10.0,
        child: const Icon(Icons.star),
        onPressed: (){

        },
      ),
      floatingActionButtonLocation: FloatingActionButtonLocation.endTop,
      drawer: Drawer( 
          child: ListView( 
            children: const <Widget>[ 
              DrawerHeader( 
                decoration: BoxDecoration( 
                  color: Colors.blue, 
                ), 
                child: Text( 
                  'Menu', 
                  style: TextStyle( 
                    color: Colors.blue, 
                    fontSize: 24, 
                  ), 
                ), 
              ), 
              ListTile( 
                leading: Icon(Icons.account_circle), 
                title: Text('Item 1'), 
              ), 
              ListTile( 
                leading: Icon(Icons.back_hand_rounded), 
                title: Text('Item 2'), 
                trailing: Icon(Icons.check), 
              ), 

            ], 
          ), 
      ), 
      drawerScrimColor: Colors.blue[100], 
      bottomNavigationBar: BottomNavigationBar(
        currentIndex: 0,
        fixedColor: Colors.blue,
        items: const [
          BottomNavigationBarItem(
            label: "Trang chủ",
            icon: Icon(Icons.blinds_sharp),
        ),
        BottomNavigationBarItem(
            label: "Chi tiết",
            icon: Icon(Icons.wysiwyg),
        ),
        BottomNavigationBarItem(
          label: "Tài khoản",
          icon: Icon(Icons.account_box_outlined),
        ),
        ],
        onTap: (int indexOfItem) {}),
        
    );
  }
}
