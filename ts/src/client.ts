// This file is auto-generated, don't edit it
/**
 * This is a number module
 */
import * as $tea from '@alicloud/tea-typescript';


export default class Client {

  static parseInt(raw: string): number {
    if(raw.match(/^\d*$/)){
      return parseInt(raw);
    } else {
      throw "convert int err,raw is not pure int numbers."
    }
  }

  static parseLong(raw: string): number {
    if (raw.match(/^\d*$/)) {
      return parseInt(raw);
    } else {
      throw "convert long err,raw is not pure int numbers."
    }
  }

  static parseFloat(raw: string): number {
    if(raw.match(/^[\.\d]*$/)){
      return parseFloat(raw);
    } else {
      throw "convert float err,raw is not pure numbers."
    }
  }

  static parseDouble(raw: string): number {
    if (raw.match(/^[\.\d]*$/)) {
      return parseFloat(raw);
    } else {
      throw "convert double err,raw is not pure numbers."
    }
  }

  static itol(raw: number): number {
    return raw;
  }

  static ltoi(raw: number): number {
    return raw;
  }

  static add(val1: number, val2: number): number {
    return val1 + val2;
  }

  static sub(val1: number, val2: number): number {
    return val1 - val2;
  }

  static mul(val1: number, val2: number): number {
    return val1 * val2;
  }

  static div(val1: number, val2: number): number {
    return val1 / val2;
  }

  static gt(val1: number, val2: number): boolean {
    return val1 > val2;
  }

  static gte(val1: number, val2: number): boolean {
    return val1 >= val2;
  }

  static lt(val1: number, val2: number): boolean {
    return val1 < val2;
  }

  static lte(val1: number, val2: number): boolean {
    return val1 <= val2;
  }

}
