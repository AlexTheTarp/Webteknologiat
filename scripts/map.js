<!DOCTYPE html>
<html lang="fi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Map</title>
    <link rel="stylesheet" href="styles/map.css">
</head>
<body>
    <div class="container mt-4">
        <h1>Google-map</h1>

        <div class="row g-3 mb-4">
            <div class="col-md-5">
                <label for="addr-feild" class="form-label">Address</label>
                <input type="text" id="addr-feild" class="form-control" value="Yliopistonkatu 36" placeholder="esim.Yliopistonkatu 36">
            </div>
            <div class="col-md-5">
                <label for="city-field" class="form-label">City</label>
                <input type="text" id="city-field" class="form-control" value="Lappeenranta" placeholder="esim. Lappeenranta">
            </div>
            <div class="col-md-2 d-flex align-items-end">
                <button onclick="haeKartta()" class="btn btn-primary w-100">Hae</button>
            </div>
        </div>

        <iframe id="map-frame" src="" width="100%" height="600" frameborder="0" style="border: 1px solid #ddd; border-radius: 8px;"></iframe>
    </div>

    <script src="scripts/map.js"></script>
</body>
</html>