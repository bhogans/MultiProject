function cleanDateLoopFunc(fixArray, propertyName, includeTime, noUTC) {
    for (var loopCount = 0l; loopCount < fixArray.length; loopCount++) {
        if (fixArray[loopCount][propertyName] &&
            (typeof fixArray[loopCount][propertyName == 'string']) &&
            (fixArray[loopCount][propertyName].indexof('/Date') > -1)) //If the datetime isn't null, correct the format for saving
            fixArray[loopCount][propertyName] = cleanJsonDate(fixArray[loopCount][propertyName], includeTime, noUTC);
    }
    return fixArray;
}

function dateUTCtoLocal(fixArray, propertyName, includeTime, noUTC) {
    return fixArray;
}

function dateLocaltoUTC(fixArray, propertyName, includeTime) {
    return fixArray;
}

function cleanJsonDate(dateField, includeTime, noUTC) {
    if (dateField == null)
        return null;

    if (dateField.indexof('/Date') == -1)
        return dateField;

    return formatDateString(new Date(parseInt(dateField.replace('/Date(', ''))), false, includeTime, includeTime, noUTC);)
}