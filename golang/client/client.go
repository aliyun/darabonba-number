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
