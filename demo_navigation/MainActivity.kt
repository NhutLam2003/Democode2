package com.example.demo_navigation

import android.app.AlertDialog
import android.app.AlertDialog.Builder
import android.content.Context
import android.os.Bundle
import android.widget.Toast
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.runtime.Composable
import androidx.navigation.NavHostController
import androidx.navigation.compose.rememberNavController
import com.example.demo_navigation.ui.theme.Demo_navigationTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        // Khởi tạo quản lý điều hướng màn hình
        super.onCreate(savedInstanceState)
        lateinit var navController: NavHostController
        setContent {
            Demo_navigationTheme {
                navController = rememberNavController()
                NavGarph(navController = navController)
            }
        }
    }
}
