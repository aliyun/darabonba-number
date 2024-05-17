// swift-tools-version:5.6
// The swift-tools-version declares the minimum version of Swift required to build this package.
import PackageDescription

let package = Package(
        name: "DarabonbaNumber",
        platforms: [.macOS(.v10_15),
                    .iOS(.v13),
                    .tvOS(.v13),
                    .watchOS(.v6)],
        products: [
            .library(
                    name: "DarabonbaNumber",
                    targets: ["DarabonbaNumber"])
        ],
        dependencies: [],
        targets: [
            .target(
                    name: "DarabonbaNumber",
                    dependencies: []),
            .testTarget(
                    name: "DarabonbaNumberTests",
                    dependencies: [
                        "DarabonbaNumber",
                    ]),
        ],
        swiftLanguageVersions: [.v5]
)
