import XCTest
@testable import DarabonbaNumber

final class DarabonbaNumberTests: XCTestCase {
    func testParseInt() {
        XCTAssertEqual(100, Client.parseInt("100"))
    }
    
    func testParseLong() {
        XCTAssertEqual(100, Client.parseLong("100"))
    }
    
    func testParseFloat() {
        XCTAssertEqual(100.0, Client.parseFloat("100"))
        XCTAssertEqual(100.1, Client.parseFloat("100.1"))
    }
    
    func testParseDouble() {
        XCTAssertEqual(100.0, Client.parseDouble("100"))
        XCTAssertEqual(100.1, Client.parseDouble("100.1"))
    }
    
    func testItol() {
        XCTAssertEqual(100, Client.itol(100))
    }
    
    func testLtoi() {
        XCTAssertEqual(100, Client.ltoi(100))
    }
    
    func testAdd() {
        XCTAssertEqual(200, Client.add(100, 100))
    }
    
    func testSub() {
        XCTAssertEqual(50, Client.sub(100, 50))
    }
    
    func testMul() {
        XCTAssertEqual(1000, Client.mul(100, 10))
    }
    
    func testDiv() {
        XCTAssertEqual(2.0, Client.div(100, 50))
    }
    
    func testGt() {
        XCTAssertTrue(Client.gt(2, 1))
        XCTAssertFalse(Client.gt(1, 2))
        XCTAssertFalse(Client.gt(1, 1))
    }
    
    func testGte() {
        XCTAssertTrue(Client.gte(2, 1))
        XCTAssertFalse(Client.gte(1, 2))
        XCTAssertTrue(Client.gte(1, 1))
    }
    
    func testLt() {
        XCTAssertTrue(Client.lt(1, 2))
        XCTAssertFalse(Client.lt(2, 1))
        XCTAssertFalse(Client.lt(1, 1))
    }
    
    func testLte() {
        XCTAssertTrue(Client.lte(1, 2))
        XCTAssertFalse(Client.lte(2, 1))
        XCTAssertTrue(Client.lte(1, 1))
    }
}
