package client

import (
	"testing"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/alibabacloud-go/tea/utils"
)

func Test_ParseInt(t *testing.T) {
	num := ParseInt(tea.String("2"))
	utils.AssertEqual(t, 2, tea.IntValue(num))
}

func Test_ParseLong(t *testing.T) {
	num := ParseLong(tea.String("2"))
	utils.AssertEqual(t, int64(2), tea.Int64Value(num))
}

func Test_ParseFloat(t *testing.T) {
	num := ParseFloat(tea.String("2.0"))
	utils.AssertEqual(t, float32(2), tea.Float32Value(num))
}

func Test_ParseDouble(t *testing.T) {
	num := ParseDouble(tea.String("2.00"))
	utils.AssertEqual(t, 2.00, tea.Float64Value(num))
}

func Test_Itol(t *testing.T) {
	num := Itol(tea.Int(20))
	utils.AssertEqual(t, int64(20), tea.Int64Value(num))
}

func Test_Ltoi(t *testing.T) {
	num := Ltoi(tea.Int64(922337212))
	utils.AssertEqual(t, int(922337212), tea.IntValue(num))
}

func Test_Add(t *testing.T) {
	num := Add(tea.Int64(223), tea.Int64(232))
	print(tea.Int64Value(num))
	utils.AssertEqual(t, int64(223+232), tea.Int64Value(num))
}

func Test_Sub(t *testing.T) {
	num := Sub(tea.Int64(200), tea.Int64(300))
	utils.AssertEqual(t, int64(200-300), tea.Int64Value(num))
}

func Test_Mul(t *testing.T) {
	num := Mul(tea.Int64(200), tea.Int64(300))
	utils.AssertEqual(t, int64(200*300), tea.Int64Value(num))
}

func Test_Div(t *testing.T) {
	num := Div(tea.Int64(10), tea.Int64(30))
	utils.AssertEqual(t, float64(10.0/30.0), tea.Float64Value(num))
}

func Test_Gt(t *testing.T) {
	num := Gt(tea.Int64(10), tea.Int64(30))
	utils.AssertEqual(t, bool(10 > 30), tea.BoolValue(num))
}

func Test_Gte(t *testing.T) {
	num := Gte(tea.Int64(10), tea.Int64(30))
	utils.AssertEqual(t, bool(10 >= 30), tea.BoolValue(num))
}

func Test_Lt(t *testing.T) {
	num := Lt(tea.Int64(20), tea.Int64(60))
	utils.AssertEqual(t, bool(20 < 60), tea.BoolValue(num))
}

func Test_Lte(t *testing.T) {
	num := Lte(tea.Int64(20), tea.Int64(60))
	utils.AssertEqual(t, bool(20 <= 60), tea.BoolValue(num))
}
