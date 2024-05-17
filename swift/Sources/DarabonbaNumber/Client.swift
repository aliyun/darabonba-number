import Foundation

open class Client {
    public static func parseInt(_ raw: String?)-> Int {
        guard let raw_ = raw, let value = Int(raw_) else {
            return 0
        }
        
        return Int(value)
    }
    
    public static func parseLong(_ raw: String?) -> Int64 {
        guard let raw_ = raw, let value = Int64(raw_) else {
            return 0
        }
        
        return Int64(value)
    }
    
    public static func parseFloat(_ raw: String?) -> Float {
        guard let raw_ = raw, let value = Float(raw_) else {
            return 0
        }
        
        return Float(value)
    }
    
    public static func parseDouble(_ raw: String?) -> Double {
        guard let raw_ = raw, let value = Double(raw_) else {
            return 0
        }
        
        return Double(value)
    }
    
    public static func itol(_ val: Int?) -> Int64 {
        guard let value = val else {
            return 0
        }
        return Int64(value)
    }
    
    public static func ltoi(_ val: Int64?) -> Int? {
        guard let val_ = val, let value = Int(exactly: val_) else {
            return 0
        }
        return value
    }

    public static func add(_ val1: Int64?, _ val2: Int64?) -> Int64 {
        guard let a = val1, let b = val2 else {
            return 0
        }
        return a &+ b
    }
    
    public static func sub(_ val1: Int64?, _ val2: Int64?) -> Int64 {
        guard let a = val1, let b = val2 else {
            return 0
        }
        return a &- b
    }
    
    public static func mul(_ val1: Int64?, _ val2: Int64?)  -> Int64 {
        guard let a = val1, let b = val2 else {
            return 0
        }
        return a &* b
    }
    
    public static func div(_ val1: Int64?, _ val2: Int64?) -> Double {
        guard let a = val1, let b = val2, b != 0 else {
            return Double.nan
        }
        return Double(a) / Double(b)
    }
    
    public static func gt(_ val1: Int64?, _ val2: Int64?) -> Bool {
        guard let a = val1, let b = val2 else {
            return false
        }
        return a > b
    }
    
    public static func gte(_ val1: Int64?, _ val2: Int64?) -> Bool {
        guard let a = val1, let b = val2 else {
            return false
        }
        return a >= b
    }
    
    public static func lt(_ val1: Int64?, _ val2: Int64?) -> Bool {
        guard let a = val1, let b = val2 else {
            return false
        }
        return a < b
    }
    
    public static func lte(_ val1: Int64?, _ val2: Int64?) -> Bool {
        guard let a = val1, let b = val2 else {
            return false
        }
        return a <= b
    }
}
