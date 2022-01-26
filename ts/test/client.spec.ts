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


    it('itol & ltoi should ok', function () {
        assert.deepStrictEqual(Client.itol(2), 2);
        assert.deepStrictEqual(Client.itol(3), 3);
    });


    it('number operate should ok', function () {
        assert.deepStrictEqual(Client.add(2, 3), 5);
        assert.deepStrictEqual(Client.sub(5, 3), 2);
        assert.deepStrictEqual(Client.mul(5, 3), 15);
        assert.deepStrictEqual(Client.div(6, 3), 2);
        assert.deepStrictEqual(Client.gt(6, 3), true);
        assert.deepStrictEqual(Client.gt(3, 6), false);
        assert.deepStrictEqual(Client.gte(3, 3), true);
        assert.deepStrictEqual(Client.gte(6, 3), true);
        assert.deepStrictEqual(Client.gte(3, 6), false);

        assert.deepStrictEqual(Client.lt(6, 3), false);
        assert.deepStrictEqual(Client.lt(3, 6), true);
        assert.deepStrictEqual(Client.lte(3, 3), true);
        assert.deepStrictEqual(Client.lte(6, 3), false);
        assert.deepStrictEqual(Client.lte(3, 6), true);
    });
});