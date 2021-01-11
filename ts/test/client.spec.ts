import Client from '../src/client';

import * as $tea from '@alicloud/tea-typescript';
import assert from 'assert';
import 'mocha';


describe('Darabonba Number', function () {
    it('Module should ok', function () {
        assert.ok(Client);
    });

    it('parseInt should ok', function () {
        assert.deepStrictEqual(Client.parseInt("2"), 2);
        try{
            Client.parseInt("2aa");
        } catch(e) {
            assert.deepStrictEqual(e, "convert int err,raw is not pure int numbers.");
        }
    });

    it('parseFloat should ok', function () {
        assert.deepStrictEqual(Client.parseFloat("2.1"), 2.1);
        try{
            Client.parseFloat("2aa");
        } catch(e) {
            assert.deepStrictEqual(e, "convert float err,raw is not pure numbers.");
        }
    });

    it('parseDouble should ok', function () {
        assert.deepStrictEqual(Client.parseDouble("2.1"), 2.1);
        try{
            Client.parseDouble("2aa");
        } catch(e) {
            assert.deepStrictEqual(e, "convert double err,raw is not pure numbers.");
        }
    });
});