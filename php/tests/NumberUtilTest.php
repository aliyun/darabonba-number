<?php

namespace AlibabaCloud\Darabonba\Number\Tests;

use AlibabaCloud\Darabonba\Number\NumberUtil;
use PHPUnit\Framework\TestCase;

/**
 * @internal
 * @coversNothing
 */
class NumberUtilTest extends TestCase
{
    public function testParseInt()
    {
        $this->assertEquals('integer', \gettype(NumberUtil::parseInt('123')));
    }

    public function testParseFloat()
    {
        $res = NumberUtil::parseFloat('123.123456');
        $this->assertEquals(123.123456, $res);
        $this->assertEquals('double', \gettype($res));
    }

    public function testParseDouble()
    {
        $res = NumberUtil::parseFloat('123.123456');
        $this->assertEquals(123.123456, $res);
        $this->assertEquals('double', \gettype($res));
    }
}
