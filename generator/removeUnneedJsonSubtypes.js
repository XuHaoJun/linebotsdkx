const { globSync } = require("glob");
const fs = require("fs-extra");

const pattern = "**/*.cs"; // Adjust the pattern as needed

const files = globSync(pattern);
console.log(files);
// if (err) {
//   console.error("Error finding files:", err);
//   return;
// }

files.forEach((file) => {
  if (file.includes("Test") || !file.includes("Model") || file.includes("obj")) {
    return;
  }
  fs.readFile(file, "utf8", (err, data) => {
    if (err) {
      console.error(`Error reading file ${file}:`, err);
      return;
    }

    const updatedData = processFileContent(data);

    fs.writeFile(file, updatedData, "utf8", (err) => {
      if (err) {
        console.error(`Error writing file ${file}:`, err);
      } else {
        console.log(`Processed file: ${file}`);
      }
    });
  });
});

function processFileContent(content) {
  // Regular expression to match class definitions and their inherited interfaces
  const classRegex =
    /(\[JsonConverter\(.*?\)\]\s*)?public partial class (\w+)\s*:\s*([^{\n]+)/g;
  return content.replace(
    classRegex,
    (match, jsonConverterAttr, className, inheritedInterfaces) => {
      const interfaces = inheritedInterfaces.split(",").map((i) => i.trim());

      // Check if the class only inherits IValidatableObject
      if (interfaces.length > 1 && interfaces.includes("IValidatableObject")) {
        return match.replace(jsonConverterAttr, "");
      }

      return match;
    }
  );
}
