# ThaiNationalIDCardJson
ThaiNationalIDCard Json WebserviceHost

 เป็นโค้ด vb.net ที่พัฒนาเพิ่มเติมจาก ThaiNationalIDCard
 <br>ให้สามารถ Run ตัวเองเป็น WebServiceHost แบบ Selfhost
 <br>จากนั้นก็สามารถเขียนโค้ด javascript หรื่อภาษาอื่น ๆ 
 <br>มาเรียกใช้ข้อมูล json จาก localhost ด้วย port ที่ต้องการได้

# วิธีใช้งาน
  1. bluid โค้ด vb.net ให้สร้างตัว exe ออกมา
  2. เรียกใช้งานตัว exe ต้อง run as admininstrator เพื่อให้ WebServiceHost ทำงานได้
  3. เชื่อมต่อเครื่องอ่านบัตร และเสียบบัตรประชาชน
  4. เขียนโค้ดสำหรับอ่านค่าไปแสดงผลที่เว็บไซต์ หลังจาก run ตัว exe แล้ว

# โค้ดตัวอย่าง Javascript อ่าน Json
```
<script>
var requestOptions = {
  method: 'GET',
  redirect: 'follow',
};

fetch("http://localhost:8000/json/", requestOptions)
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(error => console.log('error', error));
</script>
```
# reference code
 - https://github.com/chakphanu/ThaiNationalIDCard
 - https://github.com/dotnetthailand/ThaiNationalIDCard
 - http://hosxp.net/index.php?option=com_smf&topic=22496
 - http://www.g2gsoft.com/webboard/forum.php?mod=viewthread&tid=311
 - http://www.g2gsoft.com/webboard/forum.php?mod=viewthread&tid=317
 - https://learn.microsoft.com/en-us/dotnet/api/system.servicemodel.web.webservicehost?redirectedfrom=MSDN&view=netframework-4.8.1
 - https://learn.microsoft.com/en-us/dotnet/api/system.servicemodel.web.weboperationcontext.outgoingrequest?view=netframework-4.8
 - https://www.codeproject.com/Questions/1067471/how-to-resolve-cross-domain-issues-using-wcf-servi
 - https://www.codeproject.com/Articles/1184324/How-to-Create-a-WCF-WebService-in-VB-NET
 - https://stackoverflow.com/questions/11403333/httplistener-with-https-support
 - https://itecnote.com/tecnote/r-httplistener-with-https-support/
