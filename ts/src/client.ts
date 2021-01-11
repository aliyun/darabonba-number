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

  static parseFloat(raw: string): number {
    if(raw.match(/^[\.\d]*$/)){
      return parseFloat(raw);
    } else {
      throw "convert float err,raw is not pure numbers."
    }
  }

  static parseDouble(raw: string): number {
    if(raw.match(/^[\.\d]*$/)){
      return parseFloat(raw);
    } else {
      throw "convert double err,raw is not pure numbers."
    }
  }

}
