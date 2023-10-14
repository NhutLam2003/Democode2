package com.example.bai5_androi

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.lazy.grid.GridCells
import androidx.compose.foundation.lazy.grid.LazyVerticalGrid
import androidx.compose.foundation.shape.CircleShape
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Divider
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.material3.TopAppBar
import androidx.compose.material3.TopAppBarDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateMapOf
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.clip
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.bai5_androi.ui.theme.Bai5_androiTheme
import net.objecthunter.exp4j.ExpressionBuilder

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            Bai5_androiTheme {
                // A surface container using the 'background' color from the theme
                Surface(
                    modifier = Modifier.fillMaxSize(),
                    color = MaterialTheme.colorScheme.background
                ) {
                   SimpleCalculatorScreen();
                }
            }
        }
    }
}
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun SimpleCalculatorScreen(modifier: Modifier=Modifier)
{
    var _expression by remember{ mutableStateOf("") }
    var _result by remember{ mutableStateOf("0") }
    var lsKeys = listOf<String>("C","DEL","%","/",
            "7", "8", "9", "x",
            "4", "5", "6", "-",
            "1", "2", "3", "+",
            "Ans", "0", ".", "="
        )
    var nhanPhim: (String)->Unit = {
        when(it){
            "C" -> {
                _expression=""
                _result="0"
            }
            "DEL" ->{
                if(_expression.length>0){
                    _expression = _expression.substring(0,(_expression.length-1))
                }
            }
            "Ans"-> {
                _expression = _result
            }
            "=" -> {
                _result = calculate(_expression)
            }
            else -> {
                _expression +=it
            }
        }
    }

    Scaffold (
        topBar = {
            TopAppBar(
                title ={
                    Text(
                        text = "Máy tính đơn giản",
                        fontWeight = FontWeight.Bold
                    )
                },
                colors = TopAppBarDefaults.smallTopAppBarColors(
                    containerColor =  Color.Blue,
                    titleContentColor = Color.White
                )
            )
        }
    ) {
        Column(modifier = modifier.padding(it)) {
            TextField(
                value = _expression,
                onValueChange = {_expression = it},
                modifier = modifier.fillMaxWidth(), singleLine = true,
                readOnly = true,
                textStyle = TextStyle(fontSize = 45.sp, textAlign = TextAlign.Right),
                colors = TextFieldDefaults.textFieldColors(
                    textColor = Color.Blue,
                    containerColor = Color.White,
                    focusedIndicatorColor = Color.Transparent,
                    unfocusedIndicatorColor = Color.Transparent
                )
            )
            TextField(
                value = _result,
                onValueChange = {_result = it},
                modifier = modifier.fillMaxWidth(), singleLine = true,
                readOnly = true,
                textStyle = TextStyle(fontSize = 35.sp, textAlign = TextAlign.Right),
                colors = TextFieldDefaults.textFieldColors(
                    textColor = Color.Blue,
                    containerColor = Color.White,
                    focusedIndicatorColor = Color.Transparent,
                    unfocusedIndicatorColor = Color.Transparent
                )
            )
            Divider(
                modifier = modifier.padding(top = 10.dp, bottom = 10.dp),
                color = Color.LightGray
            )
            LazyVerticalGrid(
                modifier = modifier
                    .fillMaxSize()
                    .padding(top = 40.dp, start = 12.dp, end = 12.dp),
                verticalArrangement = Arrangement.SpaceEvenly,
                horizontalArrangement = Arrangement.SpaceEvenly,
                columns = GridCells.Fixed(4),
                content = {
                    items (lsKeys.count()){
                        KeyFunction(lsKeys[it], onClick = {nhanPhim(it)})
                    }
                }

            )

        }
    }


}

@Composable
fun KeyFunction(
    label: String,
    containerColor: Color = Color.LightGray,
    onClick: (String) -> Unit,
    modifier: Modifier = Modifier
)
{
    Button(
        modifier = modifier
            .size(70.dp, 70.dp)
            .clip(shape = CircleShape),
        onClick = {onClick(label)},
        colors = ButtonDefaults.buttonColors(
            containerColor = containerColor,
            contentColor = Color.Red
        )
    ) {
        Text(
            modifier = modifier.fillMaxWidth(),
            text = label,
            color = Color.Red,
            fontSize = 18.sp,
            textAlign = TextAlign.Center,
            fontWeight = FontWeight.Bold
        )
    }

}
fun calculate(exp: String):String{
    var s_exp = exp.replace("x","*")
        .replace("%","/100")
    val eval = ExpressionBuilder(s_exp).build()
    return eval.evaluate().toString()
}

@Preview(showBackground = true)
@Composable
fun GreetingPreview() {
    Bai5_androiTheme {
        SimpleCalculatorScreen();
    }
}