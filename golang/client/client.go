// This file is auto-generated, don't edit it. Thanks.
/**
 * This is a number module
 */
package client

import (
	"strconv"

	"github.com/alibabacloud-go/tea/tea"
)

func ParseInt(raw *string) (_result *int) {
	num, _ := strconv.Atoi(tea.StringValue(raw))
	return tea.Int(num)
}

func ParseLong(raw *string) (_result *int64) {
	num, _ := strconv.ParseInt(tea.StringValue(raw), 0, 64)
	return tea.Int64(num)
}

func ParseFloat(raw *string) (_result *float32) {
	f, _ := strconv.ParseFloat(tea.StringValue(raw), 32)
	return tea.Float32(float32(f))
}

func ParseDouble(raw *string) (_result *float64) {
	f, _ := strconv.ParseFloat(tea.StringValue(raw), 64)
	return tea.Float64(f)
}

func Itol(raw *int32) (_result *int64) {
	f := int64(tea.Int32Value(raw))
	return tea.Int64(f)
}

func Ltoi(raw *int64) (_result *int32) {
	f := int32(tea.Int64Value(raw))
	return tea.Int32(f)
}

func Add(raw1 *int64, raw2 *int64) (_result *int64) {
	f := tea.Int64Value(raw1) + tea.Int64Value(raw2)
	return tea.Int64(f)
}

func Sub(raw1 *int64, raw2 *int64) (_result *int64) {
	f := tea.Int64Value(raw1) - tea.Int64Value(raw2)
	return tea.Int64(f)
}

func Mul(raw1 *int64, raw2 *int64) (_result *int64) {
	f := tea.Int64Value(raw1) * tea.Int64Value(raw2)
	return tea.Int64(f)
}

func Div(raw1 *int64, raw2 *int64) (_result *float64) {
	f := ((float64)(tea.Int64Value(raw1))) / ((float64)(tea.Int64Value(raw2)))
	return tea.Float64(f)
}

func Gt(raw1 *int64, raw2 *int64) (_result *bool) {
	f := tea.Int64Value(raw1) > tea.Int64Value(raw2)
	return tea.Bool(f)
}

func Gte(raw1 *int64, raw2 *int64) (_result *bool) {
	f := tea.Int64Value(raw1) >= tea.Int64Value(raw2)
	return tea.Bool(f)
}

func Lt(raw1 *int64, raw2 *int64) (_result *bool) {
	f := tea.Int64Value(raw1) < tea.Int64Value(raw2)
	return tea.Bool(f)
}

func Lte(raw1 *int64, raw2 *int64) (_result *bool) {
	f := tea.Int64Value(raw1) <= tea.Int64Value(raw2)
	return tea.Bool(f)
}
