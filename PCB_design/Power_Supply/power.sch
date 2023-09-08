<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE eagle SYSTEM "eagle.dtd">
<eagle version="9.6.2">
<drawing>
<settings>
<setting alwaysvectorfont="no"/>
<setting verticaltext="up"/>
</settings>
<grid distance="0.1" unitdist="inch" unit="inch" style="lines" multiple="1" display="yes" altdistance="0.01" altunitdist="inch" altunit="inch"/>
<layers>
<layer number="1" name="Top" color="4" fill="1" visible="no" active="no"/>
<layer number="16" name="Bottom" color="1" fill="1" visible="no" active="no"/>
<layer number="17" name="Pads" color="2" fill="1" visible="no" active="no"/>
<layer number="18" name="Vias" color="2" fill="1" visible="no" active="no"/>
<layer number="19" name="Unrouted" color="6" fill="1" visible="no" active="no"/>
<layer number="20" name="Dimension" color="15" fill="1" visible="no" active="no"/>
<layer number="21" name="tPlace" color="7" fill="1" visible="no" active="no"/>
<layer number="22" name="bPlace" color="7" fill="1" visible="no" active="no"/>
<layer number="23" name="tOrigins" color="15" fill="1" visible="no" active="no"/>
<layer number="24" name="bOrigins" color="15" fill="1" visible="no" active="no"/>
<layer number="25" name="tNames" color="7" fill="1" visible="no" active="no"/>
<layer number="26" name="bNames" color="7" fill="1" visible="no" active="no"/>
<layer number="27" name="tValues" color="7" fill="1" visible="no" active="no"/>
<layer number="28" name="bValues" color="7" fill="1" visible="no" active="no"/>
<layer number="29" name="tStop" color="7" fill="3" visible="no" active="no"/>
<layer number="30" name="bStop" color="7" fill="6" visible="no" active="no"/>
<layer number="31" name="tCream" color="7" fill="4" visible="no" active="no"/>
<layer number="32" name="bCream" color="7" fill="5" visible="no" active="no"/>
<layer number="33" name="tFinish" color="6" fill="3" visible="no" active="no"/>
<layer number="34" name="bFinish" color="6" fill="6" visible="no" active="no"/>
<layer number="35" name="tGlue" color="7" fill="4" visible="no" active="no"/>
<layer number="36" name="bGlue" color="7" fill="5" visible="no" active="no"/>
<layer number="37" name="tTest" color="7" fill="1" visible="no" active="no"/>
<layer number="38" name="bTest" color="7" fill="1" visible="no" active="no"/>
<layer number="39" name="tKeepout" color="4" fill="11" visible="no" active="no"/>
<layer number="40" name="bKeepout" color="1" fill="11" visible="no" active="no"/>
<layer number="41" name="tRestrict" color="4" fill="10" visible="no" active="no"/>
<layer number="42" name="bRestrict" color="1" fill="10" visible="no" active="no"/>
<layer number="43" name="vRestrict" color="2" fill="10" visible="no" active="no"/>
<layer number="44" name="Drills" color="7" fill="1" visible="no" active="no"/>
<layer number="45" name="Holes" color="7" fill="1" visible="no" active="no"/>
<layer number="46" name="Milling" color="3" fill="1" visible="no" active="no"/>
<layer number="47" name="Measures" color="7" fill="1" visible="no" active="no"/>
<layer number="48" name="Document" color="7" fill="1" visible="no" active="no"/>
<layer number="49" name="Reference" color="7" fill="1" visible="no" active="no"/>
<layer number="51" name="tDocu" color="7" fill="1" visible="no" active="no"/>
<layer number="52" name="bDocu" color="7" fill="1" visible="no" active="no"/>
<layer number="88" name="SimResults" color="9" fill="1" visible="yes" active="yes"/>
<layer number="89" name="SimProbes" color="9" fill="1" visible="yes" active="yes"/>
<layer number="90" name="Modules" color="5" fill="1" visible="yes" active="yes"/>
<layer number="91" name="Nets" color="2" fill="1" visible="yes" active="yes"/>
<layer number="92" name="Busses" color="1" fill="1" visible="yes" active="yes"/>
<layer number="93" name="Pins" color="2" fill="1" visible="no" active="yes"/>
<layer number="94" name="Symbols" color="4" fill="1" visible="yes" active="yes"/>
<layer number="95" name="Names" color="7" fill="1" visible="yes" active="yes"/>
<layer number="96" name="Values" color="7" fill="1" visible="yes" active="yes"/>
<layer number="97" name="Info" color="7" fill="1" visible="yes" active="yes"/>
<layer number="98" name="Guide" color="6" fill="1" visible="yes" active="yes"/>
</layers>
<schematic xreflabel="%F%N/%S.%C%R" xrefpart="/%S.%C%R">
<libraries>
<library name="SamacSys_Parts">
<description>&lt;b&gt;https://componentsearchengine.com&lt;/b&gt;&lt;p&gt;
&lt;author&gt;Created by SamacSys&lt;/author&gt;</description>
<packages>
<package name="65100516121">
<description>&lt;b&gt;65100516121&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.6" y="-1" dx="2.5" dy="0.5" layer="1" rot="R90"/>
<smd name="2" x="-0.8" y="-1" dx="2.5" dy="0.5" layer="1" rot="R90"/>
<smd name="3" x="0" y="-1" dx="2.5" dy="0.5" layer="1" rot="R90"/>
<smd name="4" x="0.8" y="-1" dx="2.5" dy="0.5" layer="1" rot="R90"/>
<smd name="5" x="1.6" y="-1" dx="2.5" dy="0.5" layer="1" rot="R90"/>
<smd name="6" x="-4.4" y="-1" dx="2.5" dy="2" layer="1" rot="R90"/>
<smd name="7" x="4.4" y="-1" dx="2.5" dy="2" layer="1" rot="R90"/>
<smd name="8" x="4.4" y="-6.5" dx="2.5" dy="2" layer="1" rot="R90"/>
<smd name="9" x="-4.4" y="-6.5" dx="2.5" dy="2" layer="1" rot="R90"/>
<hole x="-2.2" y="-3.6" drill="0.9"/>
<hole x="2.2" y="-3.6" drill="0.9"/>
<text x="-0.434" y="-5.144" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="-0.434" y="-5.144" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-3.85" y1="0" x2="3.85" y2="0" width="0.2" layer="51"/>
<wire x1="3.85" y1="0" x2="3.85" y2="-9.25" width="0.2" layer="51"/>
<wire x1="3.85" y1="-9.25" x2="-3.85" y2="-9.25" width="0.2" layer="51"/>
<wire x1="-3.85" y1="-9.25" x2="-3.85" y2="0" width="0.2" layer="51"/>
<wire x1="-3.85" y1="-9.25" x2="3.85" y2="-9.25" width="0.2" layer="21"/>
<wire x1="-3.85" y1="-2.492" x2="-3.85" y2="-4.98" width="0.2" layer="21"/>
<wire x1="3.85" y1="-2.492" x2="3.85" y2="-4.98" width="0.2" layer="21"/>
<circle x="-1.641" y="0.771" radius="0.048259375" width="0.2" layer="25"/>
</package>
<package name="SOT95P280X145-5N">
<description>&lt;b&gt;SOT23, 5 Lead CASE 527AH ISSUE A&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.25" y="0.95" dx="1.15" dy="0.6" layer="1"/>
<smd name="2" x="-1.25" y="0" dx="1.15" dy="0.6" layer="1"/>
<smd name="3" x="-1.25" y="-0.95" dx="1.15" dy="0.6" layer="1"/>
<smd name="4" x="1.25" y="-0.95" dx="1.15" dy="0.6" layer="1"/>
<smd name="5" x="1.25" y="0.95" dx="1.15" dy="0.6" layer="1"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.075" y1="1.7" x2="2.075" y2="1.7" width="0.05" layer="51"/>
<wire x1="2.075" y1="1.7" x2="2.075" y2="-1.7" width="0.05" layer="51"/>
<wire x1="2.075" y1="-1.7" x2="-2.075" y2="-1.7" width="0.05" layer="51"/>
<wire x1="-2.075" y1="-1.7" x2="-2.075" y2="1.7" width="0.05" layer="51"/>
<wire x1="-0.8" y1="1.45" x2="0.8" y2="1.45" width="0.1" layer="51"/>
<wire x1="0.8" y1="1.45" x2="0.8" y2="-1.45" width="0.1" layer="51"/>
<wire x1="0.8" y1="-1.45" x2="-0.8" y2="-1.45" width="0.1" layer="51"/>
<wire x1="-0.8" y1="-1.45" x2="-0.8" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.8" y1="0.5" x2="0.15" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.325" y1="1.45" x2="0.325" y2="1.45" width="0.2" layer="21"/>
<wire x1="0.325" y1="1.45" x2="0.325" y2="-1.45" width="0.2" layer="21"/>
<wire x1="0.325" y1="-1.45" x2="-0.325" y2="-1.45" width="0.2" layer="21"/>
<wire x1="-0.325" y1="-1.45" x2="-0.325" y2="1.45" width="0.2" layer="21"/>
<wire x1="-1.825" y1="1.5" x2="-0.675" y2="1.5" width="0.2" layer="21"/>
</package>
<package name="CAPC3216X180N">
<description>&lt;b&gt;LMF316AB7475KLHT&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.36" y="0" dx="1.82" dy="1.1" layer="1" rot="R90"/>
<smd name="2" x="1.36" y="0" dx="1.82" dy="1.1" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.06" y1="1.06" x2="2.06" y2="1.06" width="0.05" layer="51"/>
<wire x1="2.06" y1="1.06" x2="2.06" y2="-1.06" width="0.05" layer="51"/>
<wire x1="2.06" y1="-1.06" x2="-2.06" y2="-1.06" width="0.05" layer="51"/>
<wire x1="-2.06" y1="-1.06" x2="-2.06" y2="1.06" width="0.05" layer="51"/>
<wire x1="-1.6" y1="0.8" x2="1.6" y2="0.8" width="0.1" layer="51"/>
<wire x1="1.6" y1="0.8" x2="1.6" y2="-0.8" width="0.1" layer="51"/>
<wire x1="1.6" y1="-0.8" x2="-1.6" y2="-0.8" width="0.1" layer="51"/>
<wire x1="-1.6" y1="-0.8" x2="-1.6" y2="0.8" width="0.1" layer="51"/>
<wire x1="0" y1="0.7" x2="0" y2="-0.7" width="0.2" layer="21"/>
</package>
<package name="VLS5045EX330M">
<description>&lt;b&gt;VLS5045&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.8" y="0" dx="4" dy="1.5" layer="1" rot="R90"/>
<smd name="2" x="1.8" y="0" dx="4" dy="1.5" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.5" y1="2.5" x2="2.5" y2="2.5" width="0.2" layer="51"/>
<wire x1="2.5" y1="2.5" x2="2.5" y2="-2.5" width="0.2" layer="51"/>
<wire x1="2.5" y1="-2.5" x2="-2.5" y2="-2.5" width="0.2" layer="51"/>
<wire x1="-2.5" y1="-2.5" x2="-2.5" y2="2.5" width="0.2" layer="51"/>
<wire x1="-3.55" y1="3.5" x2="3.55" y2="3.5" width="0.1" layer="51"/>
<wire x1="3.55" y1="3.5" x2="3.55" y2="-3.5" width="0.1" layer="51"/>
<wire x1="3.55" y1="-3.5" x2="-3.55" y2="-3.5" width="0.1" layer="51"/>
<wire x1="-3.55" y1="-3.5" x2="-3.55" y2="3.5" width="0.1" layer="51"/>
<wire x1="-2.5" y1="2.5" x2="2.5" y2="2.5" width="0.1" layer="21"/>
<wire x1="-2.5" y1="-2.5" x2="2.54" y2="-2.5" width="0.1" layer="21"/>
</package>
<package name="SOT95P240X115-3N">
<description>&lt;b&gt;(sot-23 ssd3)_1&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.2" y="0.95" dx="0.9" dy="0.6" layer="1"/>
<smd name="2" x="-1.2" y="-0.95" dx="0.9" dy="0.6" layer="1"/>
<smd name="3" x="1.2" y="0" dx="0.9" dy="0.6" layer="1"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-1.9" y1="1.8" x2="1.9" y2="1.8" width="0.05" layer="51"/>
<wire x1="1.9" y1="1.8" x2="1.9" y2="-1.8" width="0.05" layer="51"/>
<wire x1="1.9" y1="-1.8" x2="-1.9" y2="-1.8" width="0.05" layer="51"/>
<wire x1="-1.9" y1="-1.8" x2="-1.9" y2="1.8" width="0.05" layer="51"/>
<wire x1="-0.675" y1="1.45" x2="0.675" y2="1.45" width="0.1" layer="51"/>
<wire x1="0.675" y1="1.45" x2="0.675" y2="-1.45" width="0.1" layer="51"/>
<wire x1="0.675" y1="-1.45" x2="-0.675" y2="-1.45" width="0.1" layer="51"/>
<wire x1="-0.675" y1="-1.45" x2="-0.675" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.675" y1="0.5" x2="0.275" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.4" y1="1.45" x2="0.4" y2="1.45" width="0.2" layer="21"/>
<wire x1="0.4" y1="1.45" x2="0.4" y2="-1.45" width="0.2" layer="21"/>
<wire x1="0.4" y1="-1.45" x2="-0.4" y2="-1.45" width="0.2" layer="21"/>
<wire x1="-0.4" y1="-1.45" x2="-0.4" y2="1.45" width="0.2" layer="21"/>
<wire x1="-1.65" y1="1.5" x2="-0.75" y2="1.5" width="0.2" layer="21"/>
</package>
<package name="CAPC3225X270N">
<description>&lt;b&gt;1210_21&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.35" y="0" dx="2.72" dy="1.22" layer="1" rot="R90"/>
<smd name="2" x="1.35" y="0" dx="2.72" dy="1.22" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.11" y1="1.51" x2="2.11" y2="1.51" width="0.05" layer="51"/>
<wire x1="2.11" y1="1.51" x2="2.11" y2="-1.51" width="0.05" layer="51"/>
<wire x1="2.11" y1="-1.51" x2="-2.11" y2="-1.51" width="0.05" layer="51"/>
<wire x1="-2.11" y1="-1.51" x2="-2.11" y2="1.51" width="0.05" layer="51"/>
<wire x1="-1.6" y1="1.25" x2="1.6" y2="1.25" width="0.1" layer="51"/>
<wire x1="1.6" y1="1.25" x2="1.6" y2="-1.25" width="0.1" layer="51"/>
<wire x1="1.6" y1="-1.25" x2="-1.6" y2="-1.25" width="0.1" layer="51"/>
<wire x1="-1.6" y1="-1.25" x2="-1.6" y2="1.25" width="0.1" layer="51"/>
<wire x1="0" y1="1.15" x2="0" y2="-1.15" width="0.2" layer="21"/>
</package>
<package name="CAPC3225X280N">
<description>&lt;b&gt;GRJ32ER71H106KE11L&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.55" y="0" dx="2.82" dy="0.91" layer="1" rot="R90"/>
<smd name="2" x="1.55" y="0" dx="2.82" dy="0.91" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.155" y1="1.56" x2="2.155" y2="1.56" width="0.05" layer="51"/>
<wire x1="2.155" y1="1.56" x2="2.155" y2="-1.56" width="0.05" layer="51"/>
<wire x1="2.155" y1="-1.56" x2="-2.155" y2="-1.56" width="0.05" layer="51"/>
<wire x1="-2.155" y1="-1.56" x2="-2.155" y2="1.56" width="0.05" layer="51"/>
<wire x1="-1.6" y1="1.25" x2="1.6" y2="1.25" width="0.1" layer="51"/>
<wire x1="1.6" y1="1.25" x2="1.6" y2="-1.25" width="0.1" layer="51"/>
<wire x1="1.6" y1="-1.25" x2="-1.6" y2="-1.25" width="0.1" layer="51"/>
<wire x1="-1.6" y1="-1.25" x2="-1.6" y2="1.25" width="0.1" layer="51"/>
<wire x1="0" y1="1.15" x2="0" y2="-1.15" width="0.2" layer="21"/>
</package>
<package name="TCR2EF50LMCT">
<description>&lt;b&gt;TCR2EF50,LM(CT-2&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-0.95" y="-1.2" dx="1" dy="0.8" layer="1" rot="R90"/>
<smd name="2" x="0" y="-1.2" dx="1" dy="0.6" layer="1" rot="R90"/>
<smd name="3" x="0.95" y="-1.2" dx="1" dy="0.8" layer="1" rot="R90"/>
<smd name="4" x="0.95" y="1.2" dx="1" dy="0.8" layer="1" rot="R90"/>
<smd name="5" x="-0.95" y="1.2" dx="1" dy="0.8" layer="1" rot="R90"/>
<text x="0" y="-0.4" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="-0.4" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-1.45" y1="-0.8" x2="1.45" y2="-0.8" width="0.2" layer="51"/>
<wire x1="1.45" y1="-0.8" x2="1.45" y2="0.8" width="0.2" layer="51"/>
<wire x1="1.45" y1="0.8" x2="-1.45" y2="0.8" width="0.2" layer="51"/>
<wire x1="-1.45" y1="0.8" x2="-1.45" y2="-0.8" width="0.2" layer="51"/>
<wire x1="-2.45" y1="2.7" x2="2.45" y2="2.7" width="0.1" layer="51"/>
<wire x1="2.45" y1="2.7" x2="2.45" y2="-3.5" width="0.1" layer="51"/>
<wire x1="2.45" y1="-3.5" x2="-2.45" y2="-3.5" width="0.1" layer="51"/>
<wire x1="-2.45" y1="-3.5" x2="-2.45" y2="2.7" width="0.1" layer="51"/>
<wire x1="-0.95" y1="-2.4" x2="-0.95" y2="-2.4" width="0.2" layer="21"/>
<wire x1="-0.95" y1="-2.4" x2="-0.95" y2="-2.5" width="0.2" layer="21" curve="180"/>
<wire x1="-0.95" y1="-2.5" x2="-0.95" y2="-2.5" width="0.2" layer="21"/>
<wire x1="-0.95" y1="-2.5" x2="-0.95" y2="-2.4" width="0.2" layer="21" curve="180"/>
<wire x1="-0.95" y1="-2.4" x2="-0.95" y2="-2.4" width="0.2" layer="21"/>
<wire x1="-0.95" y1="-2.4" x2="-0.95" y2="-2.5" width="0.2" layer="21" curve="180"/>
</package>
<package name="CAPC1005X55N">
<description>&lt;b&gt;GRM15_0.10 L=1.0mm W=0.5mm T=0.5mm&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-0.46" y="0" dx="0.62" dy="0.6" layer="1" rot="R90"/>
<smd name="2" x="0.46" y="0" dx="0.62" dy="0.6" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-0.91" y1="0.46" x2="0.91" y2="0.46" width="0.05" layer="51"/>
<wire x1="0.91" y1="0.46" x2="0.91" y2="-0.46" width="0.05" layer="51"/>
<wire x1="0.91" y1="-0.46" x2="-0.91" y2="-0.46" width="0.05" layer="51"/>
<wire x1="-0.91" y1="-0.46" x2="-0.91" y2="0.46" width="0.05" layer="51"/>
<wire x1="-0.5" y1="0.25" x2="0.5" y2="0.25" width="0.1" layer="51"/>
<wire x1="0.5" y1="0.25" x2="0.5" y2="-0.25" width="0.1" layer="51"/>
<wire x1="0.5" y1="-0.25" x2="-0.5" y2="-0.25" width="0.1" layer="51"/>
<wire x1="-0.5" y1="-0.25" x2="-0.5" y2="0.25" width="0.1" layer="51"/>
</package>
<package name="SOT95P275X130-3N">
<description>&lt;b&gt;SOT-23A&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.25" y="0.95" dx="1.25" dy="0.6" layer="1"/>
<smd name="2" x="-1.25" y="-0.95" dx="1.25" dy="0.6" layer="1"/>
<smd name="3" x="1.25" y="0" dx="1.25" dy="0.6" layer="1"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.125" y1="1.8" x2="2.125" y2="1.8" width="0.05" layer="51"/>
<wire x1="2.125" y1="1.8" x2="2.125" y2="-1.8" width="0.05" layer="51"/>
<wire x1="2.125" y1="-1.8" x2="-2.125" y2="-1.8" width="0.05" layer="51"/>
<wire x1="-2.125" y1="-1.8" x2="-2.125" y2="1.8" width="0.05" layer="51"/>
<wire x1="-0.8" y1="1.45" x2="0.8" y2="1.45" width="0.1" layer="51"/>
<wire x1="0.8" y1="1.45" x2="0.8" y2="-1.45" width="0.1" layer="51"/>
<wire x1="0.8" y1="-1.45" x2="-0.8" y2="-1.45" width="0.1" layer="51"/>
<wire x1="-0.8" y1="-1.45" x2="-0.8" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.8" y1="0.5" x2="0.15" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.275" y1="1.45" x2="0.275" y2="1.45" width="0.2" layer="21"/>
<wire x1="0.275" y1="1.45" x2="0.275" y2="-1.45" width="0.2" layer="21"/>
<wire x1="0.275" y1="-1.45" x2="-0.275" y2="-1.45" width="0.2" layer="21"/>
<wire x1="-0.275" y1="-1.45" x2="-0.275" y2="1.45" width="0.2" layer="21"/>
<wire x1="-1.875" y1="1.5" x2="-0.625" y2="1.5" width="0.2" layer="21"/>
</package>
<package name="SOT95P280X100-5N">
<description>&lt;b&gt;UJ-5&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.25" y="0.95" dx="1.15" dy="0.6" layer="1"/>
<smd name="2" x="-1.25" y="0" dx="1.15" dy="0.6" layer="1"/>
<smd name="3" x="-1.25" y="-0.95" dx="1.15" dy="0.6" layer="1"/>
<smd name="4" x="1.25" y="-0.95" dx="1.15" dy="0.6" layer="1"/>
<smd name="5" x="1.25" y="0.95" dx="1.15" dy="0.6" layer="1"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.075" y1="1.7" x2="2.075" y2="1.7" width="0.05" layer="51"/>
<wire x1="2.075" y1="1.7" x2="2.075" y2="-1.7" width="0.05" layer="51"/>
<wire x1="2.075" y1="-1.7" x2="-2.075" y2="-1.7" width="0.05" layer="51"/>
<wire x1="-2.075" y1="-1.7" x2="-2.075" y2="1.7" width="0.05" layer="51"/>
<wire x1="-0.8" y1="1.45" x2="0.8" y2="1.45" width="0.1" layer="51"/>
<wire x1="0.8" y1="1.45" x2="0.8" y2="-1.45" width="0.1" layer="51"/>
<wire x1="0.8" y1="-1.45" x2="-0.8" y2="-1.45" width="0.1" layer="51"/>
<wire x1="-0.8" y1="-1.45" x2="-0.8" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.8" y1="0.5" x2="0.15" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.325" y1="1.45" x2="0.325" y2="1.45" width="0.2" layer="21"/>
<wire x1="0.325" y1="1.45" x2="0.325" y2="-1.45" width="0.2" layer="21"/>
<wire x1="0.325" y1="-1.45" x2="-0.325" y2="-1.45" width="0.2" layer="21"/>
<wire x1="-0.325" y1="-1.45" x2="-0.325" y2="1.45" width="0.2" layer="21"/>
<wire x1="-1.825" y1="1.5" x2="-0.675" y2="1.5" width="0.2" layer="21"/>
</package>
<package name="SOT95P280X130-3N">
<description>&lt;b&gt;SOT-23&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.4" y="0.95" dx="0.9" dy="0.6" layer="1"/>
<smd name="2" x="-1.4" y="-0.95" dx="0.9" dy="0.6" layer="1"/>
<smd name="3" x="1.4" y="0" dx="0.9" dy="0.6" layer="1"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.1" y1="1.8" x2="2.1" y2="1.8" width="0.05" layer="51"/>
<wire x1="2.1" y1="1.8" x2="2.1" y2="-1.8" width="0.05" layer="51"/>
<wire x1="2.1" y1="-1.8" x2="-2.1" y2="-1.8" width="0.05" layer="51"/>
<wire x1="-2.1" y1="-1.8" x2="-2.1" y2="1.8" width="0.05" layer="51"/>
<wire x1="-0.825" y1="1.45" x2="0.825" y2="1.45" width="0.1" layer="51"/>
<wire x1="0.825" y1="1.45" x2="0.825" y2="-1.45" width="0.1" layer="51"/>
<wire x1="0.825" y1="-1.45" x2="-0.825" y2="-1.45" width="0.1" layer="51"/>
<wire x1="-0.825" y1="-1.45" x2="-0.825" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.825" y1="0.5" x2="0.125" y2="1.45" width="0.1" layer="51"/>
<wire x1="-0.6" y1="1.45" x2="0.6" y2="1.45" width="0.2" layer="21"/>
<wire x1="0.6" y1="1.45" x2="0.6" y2="-1.45" width="0.2" layer="21"/>
<wire x1="0.6" y1="-1.45" x2="-0.6" y2="-1.45" width="0.2" layer="21"/>
<wire x1="-0.6" y1="-1.45" x2="-0.6" y2="1.45" width="0.2" layer="21"/>
<wire x1="-1.85" y1="1.5" x2="-0.95" y2="1.5" width="0.2" layer="21"/>
</package>
<package name="SOT95P275X110-5N">
<description>&lt;b&gt;TSOP-5_2022&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.25" y="0.95" dx="1.25" dy="0.6" layer="1"/>
<smd name="2" x="-1.25" y="0" dx="1.25" dy="0.6" layer="1"/>
<smd name="3" x="-1.25" y="-0.95" dx="1.25" dy="0.6" layer="1"/>
<smd name="4" x="1.25" y="-0.95" dx="1.25" dy="0.6" layer="1"/>
<smd name="5" x="1.25" y="0.95" dx="1.25" dy="0.6" layer="1"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.125" y1="1.825" x2="2.125" y2="1.825" width="0.05" layer="51"/>
<wire x1="2.125" y1="1.825" x2="2.125" y2="-1.825" width="0.05" layer="51"/>
<wire x1="2.125" y1="-1.825" x2="-2.125" y2="-1.825" width="0.05" layer="51"/>
<wire x1="-2.125" y1="-1.825" x2="-2.125" y2="1.825" width="0.05" layer="51"/>
<wire x1="-0.75" y1="1.5" x2="0.75" y2="1.5" width="0.1" layer="51"/>
<wire x1="0.75" y1="1.5" x2="0.75" y2="-1.5" width="0.1" layer="51"/>
<wire x1="0.75" y1="-1.5" x2="-0.75" y2="-1.5" width="0.1" layer="51"/>
<wire x1="-0.75" y1="-1.5" x2="-0.75" y2="1.5" width="0.1" layer="51"/>
<wire x1="-0.75" y1="0.55" x2="0.2" y2="1.5" width="0.1" layer="51"/>
<wire x1="-0.275" y1="1.5" x2="0.275" y2="1.5" width="0.2" layer="21"/>
<wire x1="0.275" y1="1.5" x2="0.275" y2="-1.5" width="0.2" layer="21"/>
<wire x1="0.275" y1="-1.5" x2="-0.275" y2="-1.5" width="0.2" layer="21"/>
<wire x1="-0.275" y1="-1.5" x2="-0.275" y2="1.5" width="0.2" layer="21"/>
<wire x1="-1.875" y1="1.5" x2="-0.625" y2="1.5" width="0.2" layer="21"/>
</package>
<package name="CAPC6153X390N">
<description>&lt;b&gt;KRM55 L=6.1mm W=5.3mm T=3.7mm&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-2.53" y="0" dx="5.52" dy="1.95" layer="1" rot="R90"/>
<smd name="2" x="2.53" y="0" dx="5.52" dy="1.95" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-3.655" y1="2.91" x2="3.655" y2="2.91" width="0.05" layer="51"/>
<wire x1="3.655" y1="2.91" x2="3.655" y2="-2.91" width="0.05" layer="51"/>
<wire x1="3.655" y1="-2.91" x2="-3.655" y2="-2.91" width="0.05" layer="51"/>
<wire x1="-3.655" y1="-2.91" x2="-3.655" y2="2.91" width="0.05" layer="51"/>
<wire x1="-3.05" y1="2.65" x2="3.05" y2="2.65" width="0.1" layer="51"/>
<wire x1="3.05" y1="2.65" x2="3.05" y2="-2.65" width="0.1" layer="51"/>
<wire x1="3.05" y1="-2.65" x2="-3.05" y2="-2.65" width="0.1" layer="51"/>
<wire x1="-3.05" y1="-2.65" x2="-3.05" y2="2.65" width="0.1" layer="51"/>
<wire x1="0" y1="2.55" x2="0" y2="-2.55" width="0.2" layer="21"/>
</package>
<package name="RLS397">
<description>&lt;b&gt;RLS-397-5&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.35" y="0" dx="3.5" dy="2" layer="1" rot="R90"/>
<smd name="2" x="1.35" y="0" dx="3.5" dy="2" layer="1" rot="R90"/>
<text x="-0.325" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="-0.325" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.25" y1="1.6" x2="2.25" y2="1.6" width="0.2" layer="51"/>
<wire x1="2.25" y1="1.6" x2="2.25" y2="-1.6" width="0.2" layer="51"/>
<wire x1="2.25" y1="-1.6" x2="-2.25" y2="-1.6" width="0.2" layer="51"/>
<wire x1="-2.25" y1="-1.6" x2="-2.25" y2="1.6" width="0.2" layer="51"/>
<wire x1="-4" y1="2.75" x2="3.35" y2="2.75" width="0.1" layer="51"/>
<wire x1="3.35" y1="2.75" x2="3.35" y2="-2.75" width="0.1" layer="51"/>
<wire x1="3.35" y1="-2.75" x2="-4" y2="-2.75" width="0.1" layer="51"/>
<wire x1="-4" y1="-2.75" x2="-4" y2="2.75" width="0.1" layer="51"/>
<wire x1="-3" y1="0.2" x2="-3" y2="0.2" width="0.1" layer="21"/>
<wire x1="-3" y1="0.2" x2="-2.9" y2="0.2" width="0.1" layer="21" curve="180"/>
<wire x1="-2.9" y1="0.2" x2="-2.9" y2="0.2" width="0.1" layer="21"/>
<wire x1="-2.9" y1="0.2" x2="-3" y2="0.2" width="0.1" layer="21" curve="180"/>
</package>
<package name="CAPC3325X279N">
<description>&lt;b&gt;1210_20226&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-1.47" y="0" dx="2.72" dy="1.18" layer="1" rot="R90"/>
<smd name="2" x="1.47" y="0" dx="2.72" dy="1.18" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-2.21" y1="1.51" x2="2.21" y2="1.51" width="0.05" layer="51"/>
<wire x1="2.21" y1="1.51" x2="2.21" y2="-1.51" width="0.05" layer="51"/>
<wire x1="2.21" y1="-1.51" x2="-2.21" y2="-1.51" width="0.05" layer="51"/>
<wire x1="-2.21" y1="-1.51" x2="-2.21" y2="1.51" width="0.05" layer="51"/>
<wire x1="-1.65" y1="1.25" x2="1.65" y2="1.25" width="0.1" layer="51"/>
<wire x1="1.65" y1="1.25" x2="1.65" y2="-1.25" width="0.1" layer="51"/>
<wire x1="1.65" y1="-1.25" x2="-1.65" y2="-1.25" width="0.1" layer="51"/>
<wire x1="-1.65" y1="-1.25" x2="-1.65" y2="1.25" width="0.1" layer="51"/>
<wire x1="0" y1="1.15" x2="0" y2="-1.15" width="0.2" layer="21"/>
</package>
<package name="LEDC1608X40N">
<description>&lt;b&gt;LB Q39G&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-0.75" y="0" dx="0.95" dy="0.9" layer="1" rot="R90"/>
<smd name="2" x="0.75" y="0" dx="0.95" dy="0.9" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-1.65" y1="0.925" x2="1.65" y2="0.925" width="0.05" layer="51"/>
<wire x1="1.65" y1="0.925" x2="1.65" y2="-0.925" width="0.05" layer="51"/>
<wire x1="1.65" y1="-0.925" x2="-1.65" y2="-0.925" width="0.05" layer="51"/>
<wire x1="-1.65" y1="-0.925" x2="-1.65" y2="0.925" width="0.05" layer="51"/>
<wire x1="-0.8" y1="0.4" x2="0.8" y2="0.4" width="0.1" layer="51"/>
<wire x1="0.8" y1="0.4" x2="0.8" y2="-0.4" width="0.1" layer="51"/>
<wire x1="0.8" y1="-0.4" x2="-0.8" y2="-0.4" width="0.1" layer="51"/>
<wire x1="-0.8" y1="-0.4" x2="-0.8" y2="0.4" width="0.1" layer="51"/>
<wire x1="-0.8" y1="0.133" x2="-0.533" y2="0.4" width="0.1" layer="51"/>
<wire x1="0.75" y1="0.825" x2="-1.55" y2="0.825" width="0.2" layer="21"/>
<wire x1="-1.55" y1="0.825" x2="-1.55" y2="-0.825" width="0.2" layer="21"/>
<wire x1="-1.55" y1="-0.825" x2="0.75" y2="-0.825" width="0.2" layer="21"/>
</package>
<package name="RESC2012X55N">
<description>&lt;b&gt;TNPW0805 e3&lt;/b&gt;&lt;br&gt;
</description>
<smd name="1" x="-0.95" y="0" dx="1.45" dy="1" layer="1" rot="R90"/>
<smd name="2" x="0.95" y="0" dx="1.45" dy="1" layer="1" rot="R90"/>
<text x="0" y="0" size="1.27" layer="25" align="center">&gt;NAME</text>
<text x="0" y="0" size="1.27" layer="27" align="center">&gt;VALUE</text>
<wire x1="-1.7" y1="1" x2="1.7" y2="1" width="0.05" layer="51"/>
<wire x1="1.7" y1="1" x2="1.7" y2="-1" width="0.05" layer="51"/>
<wire x1="1.7" y1="-1" x2="-1.7" y2="-1" width="0.05" layer="51"/>
<wire x1="-1.7" y1="-1" x2="-1.7" y2="1" width="0.05" layer="51"/>
<wire x1="-1" y1="0.625" x2="1" y2="0.625" width="0.1" layer="51"/>
<wire x1="1" y1="0.625" x2="1" y2="-0.625" width="0.1" layer="51"/>
<wire x1="1" y1="-0.625" x2="-1" y2="-0.625" width="0.1" layer="51"/>
<wire x1="-1" y1="-0.625" x2="-1" y2="0.625" width="0.1" layer="51"/>
<wire x1="0" y1="0.525" x2="0" y2="-0.525" width="0.2" layer="21"/>
</package>
</packages>
<symbols>
<symbol name="65100516121">
<wire x1="5.08" y1="2.54" x2="15.24" y2="2.54" width="0.254" layer="94"/>
<wire x1="15.24" y1="-7.62" x2="15.24" y2="2.54" width="0.254" layer="94"/>
<wire x1="15.24" y1="-7.62" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<text x="16.51" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="16.51" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" length="middle"/>
<pin name="2" x="0" y="-2.54" length="middle"/>
<pin name="3" x="0" y="-5.08" length="middle"/>
<pin name="4" x="20.32" y="0" length="middle" rot="R180"/>
<pin name="5" x="20.32" y="-2.54" length="middle" rot="R180"/>
</symbol>
<symbol name="LM2703MFX-ADJ_NOPB">
<wire x1="5.08" y1="2.54" x2="22.86" y2="2.54" width="0.254" layer="94"/>
<wire x1="22.86" y1="-7.62" x2="22.86" y2="2.54" width="0.254" layer="94"/>
<wire x1="22.86" y1="-7.62" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<text x="24.13" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="24.13" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="SW" x="0" y="0" length="middle"/>
<pin name="GND" x="0" y="-2.54" length="middle"/>
<pin name="FB" x="0" y="-5.08" length="middle"/>
<pin name="!SHDN" x="27.94" y="0" length="middle" rot="R180"/>
<pin name="VIN" x="27.94" y="-2.54" length="middle" rot="R180"/>
</symbol>
<symbol name="LMF316AB7475KLHT">
<wire x1="5.588" y1="2.54" x2="5.588" y2="-2.54" width="0.254" layer="94"/>
<wire x1="7.112" y1="2.54" x2="7.112" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="5.588" y2="0" width="0.254" layer="94"/>
<wire x1="7.112" y1="0" x2="7.62" y2="0" width="0.254" layer="94"/>
<text x="8.89" y="6.35" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="8.89" y="3.81" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" visible="pad" length="middle"/>
<pin name="2" x="12.7" y="0" visible="pad" length="middle" rot="R180"/>
</symbol>
<symbol name="VLS5045EX-100M-H">
<wire x1="5.08" y1="0" x2="7.62" y2="0" width="0.254" layer="94" curve="-175.4"/>
<wire x1="7.62" y1="0" x2="10.16" y2="0" width="0.254" layer="94" curve="-175.4"/>
<wire x1="10.16" y1="0" x2="12.7" y2="0" width="0.254" layer="94" curve="-175.4"/>
<wire x1="12.7" y1="0" x2="15.24" y2="0" width="0.254" layer="94" curve="-175.4"/>
<text x="16.51" y="6.35" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="16.51" y="3.81" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" visible="pad" length="middle"/>
<pin name="2" x="20.32" y="0" visible="pad" length="middle" rot="R180"/>
</symbol>
<symbol name="BAT54CHYFHT116">
<wire x1="5.08" y1="2.54" x2="17.78" y2="2.54" width="0.254" layer="94"/>
<wire x1="17.78" y1="-5.08" x2="17.78" y2="2.54" width="0.254" layer="94"/>
<wire x1="17.78" y1="-5.08" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<text x="19.05" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="19.05" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="A_1" x="0" y="0" length="middle"/>
<pin name="A_2" x="0" y="-2.54" length="middle"/>
<pin name="K" x="22.86" y="0" length="middle" rot="R180"/>
</symbol>
<symbol name="LMF325B7106KMHP">
<wire x1="5.588" y1="2.54" x2="5.588" y2="-2.54" width="0.254" layer="94"/>
<wire x1="7.112" y1="2.54" x2="7.112" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="5.588" y2="0" width="0.254" layer="94"/>
<wire x1="7.112" y1="0" x2="7.62" y2="0" width="0.254" layer="94"/>
<text x="8.89" y="6.35" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="8.89" y="3.81" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" visible="pad" length="middle"/>
<pin name="2" x="12.7" y="0" visible="pad" length="middle" rot="R180"/>
</symbol>
<symbol name="GRJ32ER71H106KE11L">
<wire x1="5.588" y1="2.54" x2="5.588" y2="-2.54" width="0.254" layer="94"/>
<wire x1="7.112" y1="2.54" x2="7.112" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="5.588" y2="0" width="0.254" layer="94"/>
<wire x1="7.112" y1="0" x2="7.62" y2="0" width="0.254" layer="94"/>
<text x="8.89" y="6.35" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="8.89" y="3.81" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" visible="pad" length="middle"/>
<pin name="2" x="12.7" y="0" visible="pad" length="middle" rot="R180"/>
</symbol>
<symbol name="TCR2EF50,LM_CT">
<wire x1="5.08" y1="2.54" x2="27.94" y2="2.54" width="0.254" layer="94"/>
<wire x1="27.94" y1="-7.62" x2="27.94" y2="2.54" width="0.254" layer="94"/>
<wire x1="27.94" y1="-7.62" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<text x="29.21" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="29.21" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="VIN" x="0" y="0" length="middle"/>
<pin name="GND" x="0" y="-2.54" length="middle"/>
<pin name="CONTROL" x="0" y="-5.08" length="middle"/>
<pin name="NC" x="33.02" y="-2.54" length="middle" direction="nc" rot="R180"/>
<pin name="VOUT" x="33.02" y="0" length="middle" rot="R180"/>
</symbol>
<symbol name="GRM155R70J105KA12D">
<wire x1="5.588" y1="2.54" x2="5.588" y2="-2.54" width="0.254" layer="94"/>
<wire x1="7.112" y1="2.54" x2="7.112" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="5.588" y2="0" width="0.254" layer="94"/>
<wire x1="7.112" y1="0" x2="7.62" y2="0" width="0.254" layer="94"/>
<text x="8.89" y="6.35" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="8.89" y="3.81" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" visible="pad" length="middle"/>
<pin name="2" x="12.7" y="0" visible="pad" length="middle" rot="R180"/>
</symbol>
<symbol name="TC595002ECBTR">
<wire x1="5.08" y1="2.54" x2="22.86" y2="2.54" width="0.254" layer="94"/>
<wire x1="22.86" y1="-5.08" x2="22.86" y2="2.54" width="0.254" layer="94"/>
<wire x1="22.86" y1="-5.08" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<text x="24.13" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="24.13" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="-VOUT" x="0" y="0" length="middle" direction="out"/>
<pin name="-VIN" x="0" y="-2.54" length="middle" direction="in"/>
<pin name="VSS" x="27.94" y="0" length="middle" direction="pwr" rot="R180"/>
</symbol>
<symbol name="ADM7160AUJZ-2.5-R7">
<wire x1="5.08" y1="2.54" x2="22.86" y2="2.54" width="0.254" layer="94"/>
<wire x1="22.86" y1="-7.62" x2="22.86" y2="2.54" width="0.254" layer="94"/>
<wire x1="22.86" y1="-7.62" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<text x="24.13" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="24.13" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="VIN" x="0" y="0" length="middle"/>
<pin name="GND" x="0" y="-2.54" length="middle"/>
<pin name="EN" x="0" y="-5.08" length="middle"/>
<pin name="NC" x="27.94" y="0" length="middle" direction="nc" rot="R180"/>
<pin name="VOUT" x="27.94" y="-2.54" length="middle" rot="R180"/>
</symbol>
<symbol name="XC6902N251MR-G">
<wire x1="5.08" y1="2.54" x2="25.4" y2="2.54" width="0.254" layer="94"/>
<wire x1="25.4" y1="-5.08" x2="25.4" y2="2.54" width="0.254" layer="94"/>
<wire x1="25.4" y1="-5.08" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<text x="26.67" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="26.67" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="-VOUT" x="0" y="0" length="middle"/>
<pin name="GND" x="0" y="-2.54" length="middle"/>
<pin name="-VIN" x="30.48" y="0" length="middle" rot="R180"/>
</symbol>
<symbol name="NCV8114ASN165T1G">
<wire x1="5.08" y1="2.54" x2="20.32" y2="2.54" width="0.254" layer="94"/>
<wire x1="20.32" y1="-7.62" x2="20.32" y2="2.54" width="0.254" layer="94"/>
<wire x1="20.32" y1="-7.62" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<text x="21.59" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="21.59" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="IN" x="0" y="0" length="middle"/>
<pin name="GND" x="0" y="-2.54" length="middle"/>
<pin name="EN" x="0" y="-5.08" length="middle"/>
<pin name="N/C" x="25.4" y="0" length="middle" direction="nc" rot="R180"/>
<pin name="OUT" x="25.4" y="-2.54" length="middle" rot="R180"/>
</symbol>
<symbol name="NCP163ASN150T1G">
<wire x1="5.08" y1="2.54" x2="20.32" y2="2.54" width="0.254" layer="94"/>
<wire x1="20.32" y1="-7.62" x2="20.32" y2="2.54" width="0.254" layer="94"/>
<wire x1="20.32" y1="-7.62" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<text x="21.59" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="21.59" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="IN" x="0" y="0" length="middle"/>
<pin name="GND" x="0" y="-2.54" length="middle"/>
<pin name="EN" x="0" y="-5.08" length="middle"/>
<pin name="NC" x="25.4" y="0" length="middle" direction="nc" rot="R180"/>
<pin name="OUT" x="25.4" y="-2.54" length="middle" rot="R180"/>
</symbol>
<symbol name="KRM55QR72A106KH01L">
<wire x1="5.588" y1="2.54" x2="5.588" y2="-2.54" width="0.254" layer="94"/>
<wire x1="7.112" y1="2.54" x2="7.112" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="5.588" y2="0" width="0.254" layer="94"/>
<wire x1="7.112" y1="0" x2="7.62" y2="0" width="0.254" layer="94"/>
<text x="8.89" y="6.35" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="8.89" y="3.81" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" visible="pad" length="middle"/>
<pin name="2" x="12.7" y="0" visible="pad" length="middle" rot="R180"/>
</symbol>
<symbol name="RLS-397">
<wire x1="5.08" y1="2.54" x2="15.24" y2="2.54" width="0.254" layer="94"/>
<wire x1="15.24" y1="-5.08" x2="15.24" y2="2.54" width="0.254" layer="94"/>
<wire x1="15.24" y1="-5.08" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="2.54" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<text x="16.51" y="7.62" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="16.51" y="5.08" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" length="middle"/>
<pin name="2" x="0" y="-2.54" length="middle"/>
</symbol>
<symbol name="12101C335KAT2A">
<wire x1="5.588" y1="2.54" x2="5.588" y2="-2.54" width="0.254" layer="94"/>
<wire x1="7.112" y1="2.54" x2="7.112" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="5.588" y2="0" width="0.254" layer="94"/>
<wire x1="7.112" y1="0" x2="7.62" y2="0" width="0.254" layer="94"/>
<text x="8.89" y="6.35" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="8.89" y="3.81" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" visible="pad" length="middle"/>
<pin name="2" x="12.7" y="0" visible="pad" length="middle" rot="R180"/>
</symbol>
<symbol name="LT_Q39G-Q1OO-25-1">
<wire x1="5.08" y1="2.54" x2="5.08" y2="-2.54" width="0.254" layer="94"/>
<wire x1="6.35" y1="2.54" x2="3.81" y2="5.08" width="0.254" layer="94"/>
<wire x1="8.89" y1="2.54" x2="6.35" y2="5.08" width="0.254" layer="94"/>
<wire x1="2.54" y1="0" x2="5.08" y2="0" width="0.254" layer="94"/>
<wire x1="10.16" y1="0" x2="12.7" y2="0" width="0.254" layer="94"/>
<text x="12.7" y="8.89" size="1.778" layer="95">&gt;NAME</text>
<text x="12.7" y="6.35" size="1.778" layer="96">&gt;VALUE</text>
<pin name="K" x="0" y="0" visible="pad" length="short"/>
<pin name="A" x="15.24" y="0" visible="pad" length="short" rot="R180"/>
<polygon width="0.254" layer="94">
<vertex x="5.08" y="0"/>
<vertex x="10.16" y="2.54"/>
<vertex x="10.16" y="-2.54"/>
</polygon>
<polygon width="0.254" layer="94">
<vertex x="5.334" y="4.318"/>
<vertex x="4.572" y="3.556"/>
<vertex x="3.81" y="5.08"/>
</polygon>
<polygon width="0.254" layer="94">
<vertex x="7.874" y="4.318"/>
<vertex x="7.112" y="3.556"/>
<vertex x="6.35" y="5.08"/>
</polygon>
</symbol>
<symbol name="LB_Q39E-N1OO-35-1">
<wire x1="5.08" y1="2.54" x2="5.08" y2="-2.54" width="0.254" layer="94"/>
<wire x1="6.35" y1="2.54" x2="3.81" y2="5.08" width="0.254" layer="94"/>
<wire x1="8.89" y1="2.54" x2="6.35" y2="5.08" width="0.254" layer="94"/>
<wire x1="2.54" y1="0" x2="5.08" y2="0" width="0.254" layer="94"/>
<wire x1="10.16" y1="0" x2="12.7" y2="0" width="0.254" layer="94"/>
<text x="12.7" y="8.89" size="1.778" layer="95">&gt;NAME</text>
<text x="12.7" y="6.35" size="1.778" layer="96">&gt;VALUE</text>
<pin name="K" x="0" y="0" visible="pad" length="short"/>
<pin name="A" x="15.24" y="0" visible="pad" length="short" rot="R180"/>
<polygon width="0.254" layer="94">
<vertex x="5.08" y="0"/>
<vertex x="10.16" y="2.54"/>
<vertex x="10.16" y="-2.54"/>
</polygon>
<polygon width="0.254" layer="94">
<vertex x="5.334" y="4.318"/>
<vertex x="4.572" y="3.556"/>
<vertex x="3.81" y="5.08"/>
</polygon>
<polygon width="0.254" layer="94">
<vertex x="7.874" y="4.318"/>
<vertex x="7.112" y="3.556"/>
<vertex x="6.35" y="5.08"/>
</polygon>
</symbol>
<symbol name="TNPW080527K4BEEN">
<wire x1="5.08" y1="1.27" x2="12.7" y2="1.27" width="0.254" layer="94"/>
<wire x1="12.7" y1="-1.27" x2="12.7" y2="1.27" width="0.254" layer="94"/>
<wire x1="12.7" y1="-1.27" x2="5.08" y2="-1.27" width="0.254" layer="94"/>
<wire x1="5.08" y1="1.27" x2="5.08" y2="-1.27" width="0.254" layer="94"/>
<text x="13.97" y="6.35" size="1.778" layer="95" align="center-left">&gt;NAME</text>
<text x="13.97" y="3.81" size="1.778" layer="96" align="center-left">&gt;VALUE</text>
<pin name="1" x="0" y="0" visible="pad" length="middle"/>
<pin name="2" x="17.78" y="0" visible="pad" length="middle" rot="R180"/>
</symbol>
</symbols>
<devicesets>
<deviceset name="65100516121" prefix="J">
<description>&lt;b&gt;WR-COM USB Connector Mini horizontal SMD Wurth Elektronik WR-COM Series Right Angle SMT Type B Mini USB Connector Receptacle, 30 V ac, 1A&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="http://www.farnell.com/datasheets/2157009.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="65100516121" x="0" y="0"/>
</gates>
<devices>
<device name="" package="65100516121">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
<connect gate="G$1" pin="3" pad="3"/>
<connect gate="G$1" pin="4" pad="4"/>
<connect gate="G$1" pin="5" pad="5"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="" constant="no"/>
<attribute name="DESCRIPTION" value="WR-COM USB Connector Mini horizontal SMD Wurth Elektronik WR-COM Series Right Angle SMT Type B Mini USB Connector Receptacle, 30 V ac, 1A" constant="no"/>
<attribute name="HEIGHT" value="mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Wurth Elektronik" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="65100516121" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="710-65100516121" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Wurth-Elektronik/65100516121?qs=rS3zZhy2AQPLyCguT204Og%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="LM2703MFX-ADJ_NOPB" prefix="IC">
<description>&lt;b&gt;Micropower Step-Up DC/DC Converter with 350mA Peak Current Limit&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="http://www.ti.com/lit/gpn/lm2703"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="LM2703MFX-ADJ_NOPB" x="0" y="0"/>
</gates>
<devices>
<device name="" package="SOT95P280X145-5N">
<connects>
<connect gate="G$1" pin="!SHDN" pad="4"/>
<connect gate="G$1" pin="FB" pad="3"/>
<connect gate="G$1" pin="GND" pad="2"/>
<connect gate="G$1" pin="SW" pad="1"/>
<connect gate="G$1" pin="VIN" pad="5"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="LM2703MFX-ADJ/NOPB" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="https://www.arrow.com/en/products/lm2703mfx-adjnopb/texas-instruments" constant="no"/>
<attribute name="DESCRIPTION" value="Micropower Step-Up DC/DC Converter with 350mA Peak Current Limit" constant="no"/>
<attribute name="HEIGHT" value="1.45mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Texas Instruments" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="LM2703MFX-ADJ/NOPB" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="926-LM2703MFXADJNOPB" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.com/Search/Refine.aspx?Keyword=926-LM2703MFXADJNOPB" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="LMF316AB7475KLHT" prefix="C">
<description>&lt;b&gt;Multilayer Ceramic Capacitors MLCC - SMD/SMT 1206 10VDC 4.7uF 10% X7R AEC-Q200&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://4donline.ihs.com/images/VipMasterIC/IC/TAIY/TAIY-S-A0014577573/TAIY-S-A0014577337-1.pdf?hkey=EF798316E3902B6ED9A73243A3159BB0"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="LMF316AB7475KLHT" x="0" y="0"/>
</gates>
<devices>
<device name="" package="CAPC3216X180N">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value="Multilayer Ceramic Capacitors MLCC - SMD/SMT 1206 10VDC 4.7uF 10% X7R AEC-Q200" constant="no"/>
<attribute name="HEIGHT" value="1.8mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="TAIYO YUDEN" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="LMF316AB7475KLHT" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="963-LMF316AB7475KLHT" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Taiyo-Yuden/LMF316AB7475KLHT?qs=%252B6g0mu59x7Jucp0YIcNtlw%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="VLS5045EX-100M-H" prefix="L">
<description>&lt;b&gt;SMD / SMT Inductors (Coils), L=10?H, L x W x T :&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://product.tdk.com/system/files/dam/doc/product/inductor/inductor/smd/catalog/inductor_automotive_power_vls5045ex-h_en.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="VLS5045EX-100M-H" x="0" y="0"/>
</gates>
<devices>
<device name="" package="VLS5045EX330M">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="VLS5045EX-100M-H" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="https://www.arrow.com/en/products/vls5045ex-100m-h/tdk" constant="no"/>
<attribute name="DESCRIPTION" value="SMD / SMT Inductors (Coils), L=10?H, L x W x T :" constant="no"/>
<attribute name="HEIGHT" value="4mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="TDK" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="VLS5045EX-100M-H" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="810-VLS5045EX-100M-H" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/TDK/VLS5045EX-100M-H?qs=EBDBlbfErPxDDKYBGzjLDg%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="BAT54CHYFHT116" prefix="D">
<description>&lt;b&gt;Schottky Diodes &amp; Rectifiers SCHOTTKY BARRIER DIODE&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://4donline.ihs.com/images/VipMasterIC/IC/ROHM/ROHM-S-A0010595071/ROHM-S-A0010666907-1.pdf?hkey=EF798316E3902B6ED9A73243A3159BB0"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="BAT54CHYFHT116" x="0" y="0"/>
</gates>
<devices>
<device name="" package="SOT95P240X115-3N">
<connects>
<connect gate="G$1" pin="A_1" pad="1"/>
<connect gate="G$1" pin="A_2" pad="2"/>
<connect gate="G$1" pin="K" pad="3"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="" constant="no"/>
<attribute name="DESCRIPTION" value="Schottky Diodes &amp; Rectifiers SCHOTTKY BARRIER DIODE" constant="no"/>
<attribute name="HEIGHT" value="1.15mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="ROHM Semiconductor" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="BAT54CHYFHT116" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="755-BAT54CHYFHT116" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/ROHM-Semiconductor/BAT54CHYFHT116?qs=QNEnbhJQKvbxVoFekP9UeQ%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="LMF325B7106KMHP" prefix="C">
<description>&lt;b&gt;Multilayer Ceramic Capacitors MLCC - SMD/SMT 1210 10VDC 10uF 10% X7R AEC-Q200&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://4donline.ihs.com/images/VipMasterIC/IC/TAIY/TAIY-S-A0010497038/TAIY-S-A0010490867-1.pdf?hkey=6D3A4C79FDBF58556ACFDE234799DDF0"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="LMF325B7106KMHP" x="0" y="0"/>
</gates>
<devices>
<device name="" package="CAPC3225X270N">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="" constant="no"/>
<attribute name="DESCRIPTION" value="Multilayer Ceramic Capacitors MLCC - SMD/SMT 1210 10VDC 10uF 10% X7R AEC-Q200" constant="no"/>
<attribute name="HEIGHT" value="2.7mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="TAIYO YUDEN" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="LMF325B7106KMHP" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="963-LMF325B7106KMHP" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Taiyo-Yuden/LMF325B7106KMHP?qs=W%2FMpXkg%252BdQ7tCScIXneZ%2FA%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="GRJ32ER71H106KE11L" prefix="C">
<description>&lt;b&gt;Cap Ceramic 10uF 50V X7R 10% Pad SMD 1210 Soft Termination 125C T/R&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://componentsearchengine.com/Datasheets/1/GRJ32ER71H106KE11L.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="GRJ32ER71H106KE11L" x="0" y="0"/>
</gates>
<devices>
<device name="" package="CAPC3225X280N">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="GRJ32ER71H106KE11L" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="https://www.arrow.com/en/products/grj32er71h106ke11l/murata-manufacturing?region=nac" constant="no"/>
<attribute name="DESCRIPTION" value="Cap Ceramic 10uF 50V X7R 10% Pad SMD 1210 Soft Termination 125C T/R" constant="no"/>
<attribute name="HEIGHT" value="2.8mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Murata Electronics" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="GRJ32ER71H106KE11L" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="81-GRJ32ER71H106KE1L" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Murata-Electronics/GRJ32ER71H106KE11L?qs=Mkt%2FZhxPIiRCGrZ4HFiKZA%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="TCR2EF50,LM_CT" prefix="IC">
<description>&lt;b&gt;LDO Voltage Regulators 200mA LDO, Vout=5.0V, Dropout=180mV, Iq=35uA, PSRR=73dB, in SOT-25 (SMV) package&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://toshiba.semicon-storage.com/info/docget.jsp?did=13794&amp;prodName=TCR2EF50"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="TCR2EF50,LM_CT" x="0" y="0"/>
</gates>
<devices>
<device name="" package="TCR2EF50LMCT">
<connects>
<connect gate="G$1" pin="CONTROL" pad="3"/>
<connect gate="G$1" pin="GND" pad="2"/>
<connect gate="G$1" pin="NC" pad="4"/>
<connect gate="G$1" pin="VIN" pad="1"/>
<connect gate="G$1" pin="VOUT" pad="5"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="" constant="no"/>
<attribute name="DESCRIPTION" value="LDO Voltage Regulators 200mA LDO, Vout=5.0V, Dropout=180mV, Iq=35uA, PSRR=73dB, in SOT-25 (SMV) package" constant="no"/>
<attribute name="HEIGHT" value="1.4mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Toshiba" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="TCR2EF50,LM(CT" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="757-TCR2EF50LMCT" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Toshiba/TCR2EF50LMCT?qs=bZr6mbWTK5m4vMduq2OXCA%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="GRM155R70J105KA12D" prefix="C">
<description>&lt;b&gt;Multilayer Ceramic Capacitors MLCC - SMD/SMT 0402 1.0uF 6.3volts *Derate Voltage/Temp&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://psearch.en.murata.com/capacitor/product/GRM155R70J105KA12#.html"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="GRM155R70J105KA12D" x="0" y="0"/>
</gates>
<devices>
<device name="" package="CAPC1005X55N">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="GRM155R70J105KA12D" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="https://www.arrow.com/en/products/grm155r70j105ka12d/murata-manufacturing?region=nac" constant="no"/>
<attribute name="DESCRIPTION" value="Multilayer Ceramic Capacitors MLCC - SMD/SMT 0402 1.0uF 6.3volts *Derate Voltage/Temp" constant="no"/>
<attribute name="HEIGHT" value="0.55mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Murata Electronics" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="GRM155R70J105KA12D" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="81-GRM155R70J105KA2D" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Murata-Electronics/GRM155R70J105KA12D?qs=OXzh9Ga2KBHWfvlODrgZnQ%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="TC595002ECBTR" prefix="PS">
<description>&lt;b&gt;100mA -5V LDO Negative Regulator SOT-23A Microchip TC595002ECBTR, LDO Voltage Regulator, 100mA,&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://datasheet.datasheetarchive.com/originals/distributors/Datasheets-303/39564.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="TC595002ECBTR" x="0" y="0"/>
</gates>
<devices>
<device name="" package="SOT95P275X130-3N">
<connects>
<connect gate="G$1" pin="-VIN" pad="2"/>
<connect gate="G$1" pin="-VOUT" pad="1"/>
<connect gate="G$1" pin="VSS" pad="3"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="TC595002ECBTR" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="https://www.arrow.com/en/products/tc595002ecbtr/microchip-technology" constant="no"/>
<attribute name="DESCRIPTION" value="100mA -5V LDO Negative Regulator SOT-23A Microchip TC595002ECBTR, LDO Voltage Regulator, 100mA," constant="no"/>
<attribute name="HEIGHT" value="1.3mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Microchip" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="TC595002ECBTR" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="579-TC595002ECBTR" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Microchip-Technology/TC595002ECBTR?qs=n%2FfJlMG9rCbPVifAtUx8yQ%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="ADM7160AUJZ-2.5-R7" prefix="IC">
<description>&lt;b&gt;LDO Voltage Regulators 200mA LDO 25Vout&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://componentsearchengine.com/Datasheets/1/ADM7160AUJZ-2.5-R7.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="ADM7160AUJZ-2.5-R7" x="0" y="0"/>
</gates>
<devices>
<device name="" package="SOT95P280X100-5N">
<connects>
<connect gate="G$1" pin="EN" pad="3"/>
<connect gate="G$1" pin="GND" pad="2"/>
<connect gate="G$1" pin="NC" pad="4"/>
<connect gate="G$1" pin="VIN" pad="1"/>
<connect gate="G$1" pin="VOUT" pad="5"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value="LDO Voltage Regulators 200mA LDO 25Vout" constant="no"/>
<attribute name="HEIGHT" value="1mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Linear Technology" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="ADM7160AUJZ-2.5-R7" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="584-ADM7160AUJZ2.5R7" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.com/Search/Refine.aspx?Keyword=584-ADM7160AUJZ2.5R7" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="XC6902N251MR-G" prefix="IC">
<description>&lt;b&gt;LDO Voltage Regulators&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="http://www.mouser.com/ds/2/760/XC6902-846637.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="XC6902N251MR-G" x="0" y="0"/>
</gates>
<devices>
<device name="" package="SOT95P280X130-3N">
<connects>
<connect gate="G$1" pin="-VIN" pad="3"/>
<connect gate="G$1" pin="-VOUT" pad="1"/>
<connect gate="G$1" pin="GND" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="" constant="no"/>
<attribute name="DESCRIPTION" value="LDO Voltage Regulators" constant="no"/>
<attribute name="HEIGHT" value="1.3mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Torex" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="XC6902N251MR-G" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="865-XC6902N251MR-G" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Torex-Semiconductor/XC6902N251MR-G/?qs=AsjdqWjXhJ97TLkuQPXWBQ%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="NCV8114ASN165T1G" prefix="IC">
<description>&lt;b&gt;ONSEMI - NCV8114ASN165T1G - LDO REGULATOR, 300 MA, LOW IQ 1.65V AD&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://www.onsemi.com/pub/Collateral/NCV8114-D.PDF"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="NCV8114ASN165T1G" x="0" y="0"/>
</gates>
<devices>
<device name="" package="SOT95P275X110-5N">
<connects>
<connect gate="G$1" pin="EN" pad="3"/>
<connect gate="G$1" pin="GND" pad="2"/>
<connect gate="G$1" pin="IN" pad="1"/>
<connect gate="G$1" pin="N/C" pad="4"/>
<connect gate="G$1" pin="OUT" pad="5"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="NCV8114ASN165T1G" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="https://www.arrow.com/en/products/ncv8114asn165t1g/on-semiconductor?region=nac" constant="no"/>
<attribute name="DESCRIPTION" value="ONSEMI - NCV8114ASN165T1G - LDO REGULATOR, 300 MA, LOW IQ 1.65V AD" constant="no"/>
<attribute name="HEIGHT" value="1.1mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="ON Semiconductor" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="NCV8114ASN165T1G" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="863-NCV8114ASN165T1G" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/onsemi/NCV8114ASN165T1G?qs=PqoDHHvF64%252BWMsY7A2HF3Q%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="NCP163ASN150T1G" prefix="IC">
<description>&lt;b&gt;ONSEMI - NCP163ASN150T1G - LDO Voltage Regulator, Fixed, 2.2 V to 5.5 V in, 1.5 V / 250 mA out, SOT23-5&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://www.onsemi.com/pdf/datasheet/ncp163-d.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="NCP163ASN150T1G" x="0" y="0"/>
</gates>
<devices>
<device name="" package="SOT95P280X145-5N">
<connects>
<connect gate="G$1" pin="EN" pad="3"/>
<connect gate="G$1" pin="GND" pad="2"/>
<connect gate="G$1" pin="IN" pad="1"/>
<connect gate="G$1" pin="NC" pad="4"/>
<connect gate="G$1" pin="OUT" pad="5"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value="ONSEMI - NCP163ASN150T1G - LDO Voltage Regulator, Fixed, 2.2 V to 5.5 V in, 1.5 V / 250 mA out, SOT23-5" constant="no"/>
<attribute name="HEIGHT" value="1.45mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="ON Semiconductor" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="NCP163ASN150T1G" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="863-NCP163ASN150T1G" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/onsemi/NCP163ASN150T1G?qs=vLWxofP3U2x6R82l9MbdEQ%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="KRM55QR72A106KH01L" prefix="C">
<description>&lt;b&gt;Multilayer Ceramic Capacitors MLCC - SMD/SMT&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://psearch.en.murata.com/capacitor/product/KRM55QR72A106KH01#.html"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="KRM55QR72A106KH01L" x="0" y="0"/>
</gates>
<devices>
<device name="" package="CAPC6153X390N">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="ARROW_PART_NUMBER" value="KRM55QR72A106KH01L" constant="no"/>
<attribute name="ARROW_PRICE-STOCK" value="https://www.arrow.com/en/products/krm55qr72a106kh01l/murata-manufacturing?region=nac" constant="no"/>
<attribute name="DESCRIPTION" value="Multilayer Ceramic Capacitors MLCC - SMD/SMT" constant="no"/>
<attribute name="HEIGHT" value="3.9mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Murata Electronics" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="KRM55QR72A106KH01L" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="81-KRM55QR72A106KH1L" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Murata-Electronics/KRM55QR72A106KH01L?qs=qkDYIeTQ%252BElto0fJu%2F86Vw%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="RLS-397" prefix="PS">
<description>&lt;b&gt;Inductor Power Unshielded Wirewound 3.9uH 20% 100KHz 1.32A 0.14Ohm DCR 1812 Bag&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://recom-power.com/pdf/Accessories/RLS-397.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="RLS-397" x="0" y="0"/>
</gates>
<devices>
<device name="" package="RLS397">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value="Inductor Power Unshielded Wirewound 3.9uH 20% 100KHz 1.32A 0.14Ohm DCR 1812 Bag" constant="no"/>
<attribute name="HEIGHT" value="3.1mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="RECOM Power" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="RLS-397" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="919-RLS-397" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/RECOM-Power/RLS-397?qs=gZXFycFWdAMzj7SWZ0VCrw%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="12101C335KAT2A" prefix="C">
<description>&lt;b&gt;Multilayer Ceramic Capacitors MLCC - SMD/SMT 100V 3.3uF X7R 1210 10%&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://componentsearchengine.com/Datasheets/2/12101C335KAT2A.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="12101C335KAT2A" x="0" y="0"/>
</gates>
<devices>
<device name="" package="CAPC3325X279N">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value="Multilayer Ceramic Capacitors MLCC - SMD/SMT 100V 3.3uF X7R 1210 10%" constant="no"/>
<attribute name="HEIGHT" value="2.79mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="AVX" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="12101C335KAT2A" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="581-12101C335KAT2A" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/AVX/12101C335KAT2A?qs=t3bE0qb%2FqELbFuOKr%2F10pA%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="LT_Q39G-Q1OO-25-1" prefix="LED">
<description>&lt;b&gt;2.85 V Green LED 1608 (0603) SMD,Osram Opto CHIPLED 0603 LT Q39G-Q1OO-25-1&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://datasheet.datasheetarchive.com/originals/distributors/DKDS41/DSANUWW0036591.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="LT_Q39G-Q1OO-25-1" x="0" y="0"/>
</gates>
<devices>
<device name="" package="LEDC1608X40N">
<connects>
<connect gate="G$1" pin="A" pad="2"/>
<connect gate="G$1" pin="K" pad="1"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value="2.85 V Green LED 1608 (0603) SMD,Osram Opto CHIPLED 0603 LT Q39G-Q1OO-25-1" constant="no"/>
<attribute name="HEIGHT" value="0.4mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="OSRAM" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="LT Q39G-Q1OO-25-1" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="720-LTQ39GQ1S22515" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/OSRAM-Opto-Semiconductors/LT-Q39G-Q1OO-25-1?qs=74fRo9GAWszgXtz8D2kVhg%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="LB_Q39E-N1OO-35-1" prefix="LED">
<description>&lt;b&gt;Standard LEDs - SMD Blue 470nm&lt;/b&gt;&lt;p&gt;
Source: &lt;a href="https://componentsearchengine.com/Datasheets/1/LB Q39E-N1OO-35-1.pdf"&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="LB_Q39E-N1OO-35-1" x="0" y="0"/>
</gates>
<devices>
<device name="" package="LEDC1608X40N">
<connects>
<connect gate="G$1" pin="A" pad="2"/>
<connect gate="G$1" pin="K" pad="1"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value="Standard LEDs - SMD Blue 470nm" constant="no"/>
<attribute name="HEIGHT" value="0.4mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="OSRAM" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="LB Q39E-N1OO-35-1" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="720-LBQ39EN1P1351" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/OSRAM-Opto-Semiconductors/LB-Q39E-N1OO-35-1?qs=74fRo9GAWsyCe%2Fcwa%2FhbPA%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="TNPW080527K4BEEN" prefix="R">
<description>&lt;b&gt;Thin Film Resistors - SMD 27.4Kohms .1% 25ppm&lt;/b&gt;&lt;p&gt;
Source: &lt;a href=""&gt; Datasheet &lt;/a&gt;</description>
<gates>
<gate name="G$1" symbol="TNPW080527K4BEEN" x="0" y="0"/>
</gates>
<devices>
<device name="" package="RESC2012X55N">
<connects>
<connect gate="G$1" pin="1" pad="1"/>
<connect gate="G$1" pin="2" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value="Thin Film Resistors - SMD 27.4Kohms .1% 25ppm" constant="no"/>
<attribute name="HEIGHT" value="0.55mm" constant="no"/>
<attribute name="MANUFACTURER_NAME" value="Vishay" constant="no"/>
<attribute name="MANUFACTURER_PART_NUMBER" value="TNPW080527K4BEEN" constant="no"/>
<attribute name="MOUSER_PART_NUMBER" value="71-TNPW080527K4BEEN" constant="no"/>
<attribute name="MOUSER_PRICE-STOCK" value="https://www.mouser.co.uk/ProductDetail/Vishay-Dale/TNPW080527K4BEEN?qs=hgbOVb73YtioxFqgMNH98g%3D%3D" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
</devicesets>
</library>
<library name="R-786.5-0.5">
<packages>
<package name="CONV_R-786.5-0.5">
<text x="-5.715" y="4.445" size="1.27" layer="25">&gt;NAME</text>
<text x="-5.715" y="-4.445" size="1.27" layer="27" align="top-left">&gt;VALUE</text>
<circle x="-6.4" y="-1.775" radius="0.1" width="0.2" layer="21"/>
<circle x="-6.4" y="-1.775" radius="0.1" width="0.2" layer="51"/>
<wire x1="-5.75" y1="3.775" x2="-5.75" y2="-3.775" width="0.127" layer="51"/>
<wire x1="-5.75" y1="-3.775" x2="5.75" y2="-3.775" width="0.127" layer="51"/>
<wire x1="5.75" y1="-3.775" x2="5.75" y2="3.775" width="0.127" layer="51"/>
<wire x1="5.75" y1="3.775" x2="-5.75" y2="3.775" width="0.127" layer="51"/>
<wire x1="-5.75" y1="3.775" x2="-5.75" y2="-3.775" width="0.127" layer="21"/>
<wire x1="-5.75" y1="-3.775" x2="5.75" y2="-3.775" width="0.127" layer="21"/>
<wire x1="5.75" y1="-3.775" x2="5.75" y2="3.775" width="0.127" layer="21"/>
<wire x1="5.75" y1="3.775" x2="-5.75" y2="3.775" width="0.127" layer="21"/>
<wire x1="-6" y1="4.025" x2="-6" y2="-4.025" width="0.05" layer="39"/>
<wire x1="-6" y1="-4.025" x2="6" y2="-4.025" width="0.05" layer="39"/>
<wire x1="6" y1="-4.025" x2="6" y2="4.025" width="0.05" layer="39"/>
<wire x1="6" y1="4.025" x2="-6" y2="4.025" width="0.05" layer="39"/>
<pad name="1" x="-2.54" y="-1.775" drill="1" shape="square"/>
<pad name="2" x="0" y="-1.775" drill="1"/>
<pad name="3" x="2.54" y="-1.775" drill="1"/>
</package>
</packages>
<symbols>
<symbol name="R-786.5-0.5">
<text x="-10.1639" y="6.3579" size="1.77938125" layer="95">&gt;NAME</text>
<text x="-10.1614" y="-7.6227" size="1.77848125" layer="96">&gt;VALUE</text>
<wire x1="-10.16" y1="5.08" x2="-10.16" y2="-5.08" width="0.254" layer="94"/>
<wire x1="-10.16" y1="-5.08" x2="10.16" y2="-5.08" width="0.254" layer="94"/>
<wire x1="10.16" y1="-5.08" x2="10.16" y2="5.08" width="0.254" layer="94"/>
<wire x1="10.16" y1="5.08" x2="-10.16" y2="5.08" width="0.254" layer="94"/>
<pin name="+VIN" x="-15.24" y="2.54" length="middle" direction="in"/>
<pin name="+VOUT" x="15.24" y="2.54" length="middle" direction="out" rot="R180"/>
<pin name="GND" x="15.24" y="-2.54" length="middle" direction="pwr" rot="R180"/>
</symbol>
</symbols>
<devicesets>
<deviceset name="R-786.5-0.5" prefix="PS">
<description>0.5 Amp SIP3 Single Output </description>
<gates>
<gate name="G$1" symbol="R-786.5-0.5" x="0" y="0"/>
</gates>
<devices>
<device name="" package="CONV_R-786.5-0.5">
<connects>
<connect gate="G$1" pin="+VIN" pad="1"/>
<connect gate="G$1" pin="+VOUT" pad="3"/>
<connect gate="G$1" pin="GND" pad="2"/>
</connects>
<technologies>
<technology name="">
<attribute name="DESCRIPTION" value=" 0.5A DC/DC-Converter 'INNOLINE' SIP3 reg "/>
<attribute name="DIGI-KEY_PART_NUMBER" value="945-1039-ND"/>
<attribute name="MF" value="Recom Power"/>
<attribute name="MP" value="R-786.5-0.5"/>
<attribute name="PACKAGE" value="SIP-3 Recom Power"/>
<attribute name="PURCHASE-URL" value="https://pricing.snapeda.com/search/part/R-786.5-0.5/?ref=eda"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
</devicesets>
</library>
<library name="supply1" urn="urn:adsk.eagle:library:371">
<description>&lt;b&gt;Supply Symbols&lt;/b&gt;&lt;p&gt;
 GND, VCC, 0V, +5V, -5V, etc.&lt;p&gt;
 Please keep in mind, that these devices are necessary for the
 automatic wiring of the supply signals.&lt;p&gt;
 The pin name defined in the symbol is identical to the net which is to be wired automatically.&lt;p&gt;
 In this library the device names are the same as the pin names of the symbols, therefore the correct signal names appear next to the supply symbols in the schematic.&lt;p&gt;
 &lt;author&gt;Created by librarian@cadsoft.de&lt;/author&gt;</description>
<packages>
</packages>
<symbols>
<symbol name="GND" urn="urn:adsk.eagle:symbol:26925/1" library_version="1">
<wire x1="-1.905" y1="0" x2="1.905" y2="0" width="0.254" layer="94"/>
<text x="-2.54" y="-2.54" size="1.778" layer="96">&gt;VALUE</text>
<pin name="GND" x="0" y="2.54" visible="off" length="short" direction="sup" rot="R270"/>
</symbol>
</symbols>
<devicesets>
<deviceset name="GND" urn="urn:adsk.eagle:component:26954/1" prefix="GND" library_version="1">
<description>&lt;b&gt;SUPPLY SYMBOL&lt;/b&gt;</description>
<gates>
<gate name="1" symbol="GND" x="0" y="0"/>
</gates>
<devices>
<device name="">
<technologies>
<technology name=""/>
</technologies>
</device>
</devices>
</deviceset>
</devicesets>
</library>
</libraries>
<attributes>
</attributes>
<variantdefs>
</variantdefs>
<classes>
<class number="0" name="default" width="0" drill="0">
</class>
</classes>
<parts>
<part name="J1" library="SamacSys_Parts" deviceset="65100516121" device=""/>
<part name="IC2" library="SamacSys_Parts" deviceset="LM2703MFX-ADJ_NOPB" device=""/>
<part name="C1" library="SamacSys_Parts" deviceset="LMF316AB7475KLHT" device=""/>
<part name="C2" library="SamacSys_Parts" deviceset="LMF316AB7475KLHT" device=""/>
<part name="L1" library="SamacSys_Parts" deviceset="VLS5045EX-100M-H" device=""/>
<part name="D1" library="SamacSys_Parts" deviceset="BAT54CHYFHT116" device=""/>
<part name="PS1" library="R-786.5-0.5" deviceset="R-786.5-0.5" device=""/>
<part name="PS2" library="R-786.5-0.5" deviceset="R-786.5-0.5" device=""/>
<part name="C3" library="SamacSys_Parts" deviceset="LMF325B7106KMHP" device=""/>
<part name="C4" library="SamacSys_Parts" deviceset="GRJ32ER71H106KE11L" device=""/>
<part name="C5" library="SamacSys_Parts" deviceset="LMF316AB7475KLHT" device=""/>
<part name="C6" library="SamacSys_Parts" deviceset="LMF316AB7475KLHT" device=""/>
<part name="IC3" library="SamacSys_Parts" deviceset="TCR2EF50,LM_CT" device=""/>
<part name="C8" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="PS3" library="SamacSys_Parts" deviceset="TC595002ECBTR" device=""/>
<part name="C9" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="C10" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="IC4" library="SamacSys_Parts" deviceset="ADM7160AUJZ-2.5-R7" device=""/>
<part name="IC5" library="SamacSys_Parts" deviceset="XC6902N251MR-G" device=""/>
<part name="C11" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="C12" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="C13" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="C14" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="IC6" library="SamacSys_Parts" deviceset="NCV8114ASN165T1G" device=""/>
<part name="IC7" library="SamacSys_Parts" deviceset="NCP163ASN150T1G" device=""/>
<part name="C15" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="C16" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="C17" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="C18" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
<part name="C19" library="SamacSys_Parts" deviceset="KRM55QR72A106KH01L" device=""/>
<part name="PS4" library="SamacSys_Parts" deviceset="RLS-397" device=""/>
<part name="C20" library="SamacSys_Parts" deviceset="12101C335KAT2A" device=""/>
<part name="GND4" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND2" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND3" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND5" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND1" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND6" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND7" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND8" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND9" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND10" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND11" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND13" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND14" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND15" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND16" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND17" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND18" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND19" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND20" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND21" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND22" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND23" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND24" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND25" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND26" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND27" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="LED1" library="SamacSys_Parts" deviceset="LT_Q39G-Q1OO-25-1" device=""/>
<part name="LED2" library="SamacSys_Parts" deviceset="LT_Q39G-Q1OO-25-1" device=""/>
<part name="LED3" library="SamacSys_Parts" deviceset="LB_Q39E-N1OO-35-1" device=""/>
<part name="GND28" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND29" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND30" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND12" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="GND31" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="GND" device=""/>
<part name="R3" library="SamacSys_Parts" deviceset="TNPW080527K4BEEN" device=""/>
<part name="R4" library="SamacSys_Parts" deviceset="TNPW080527K4BEEN" device=""/>
<part name="C7" library="SamacSys_Parts" deviceset="GRM155R70J105KA12D" device=""/>
</parts>
<sheets>
<sheet>
<plain>
</plain>
<instances>
<instance part="J1" gate="G$1" x="-165.1" y="157.48" smashed="yes">
<attribute name="NAME" x="-156.21" y="147.32" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="-161.29" y="162.56" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="IC2" gate="G$1" x="-139.7" y="119.38" smashed="yes" rot="MR0">
<attribute name="NAME" x="-151.13" y="109.22" size="1.778" layer="95" rot="MR0" align="center-left"/>
<attribute name="VALUE" x="-146.05" y="124.46" size="1.778" layer="96" rot="MR0" align="center-left"/>
</instance>
<instance part="C1" gate="G$1" x="-200.66" y="132.08" smashed="yes" rot="R270">
<attribute name="NAME" x="-196.85" y="125.73" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="-208.28" y="132.08" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C2" gate="G$1" x="-111.76" y="134.62" smashed="yes" rot="R270">
<attribute name="VALUE" x="-105.41" y="135.89" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="L1" gate="G$1" x="-193.04" y="137.16" smashed="yes">
<attribute name="NAME" x="-184.15" y="135.89" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="-191.77" y="140.97" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="D1" gate="G$1" x="-160.02" y="137.16" smashed="yes">
<attribute name="NAME" x="-151.13" y="129.54" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="-153.67" y="142.24" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="PS1" gate="G$1" x="0" y="160.02" smashed="yes">
<attribute name="NAME" x="-10.1639" y="166.3779" size="1.77938125" layer="95"/>
<attribute name="VALUE" x="-10.1614" y="152.3973" size="1.77848125" layer="96"/>
</instance>
<instance part="PS2" gate="G$1" x="0" y="139.7" smashed="yes">
<attribute name="NAME" x="-10.1639" y="146.0579" size="1.77938125" layer="95"/>
<attribute name="VALUE" x="-10.1614" y="132.0773" size="1.77848125" layer="96"/>
</instance>
<instance part="C3" gate="G$1" x="30.48" y="160.02" smashed="yes" rot="R270">
<attribute name="NAME" x="26.67" y="153.67" size="1.778" layer="95" rot="R90" align="center-left"/>
<attribute name="VALUE" x="57.15" y="153.67" size="1.778" layer="96" rot="R180" align="center-left"/>
</instance>
<instance part="C4" gate="G$1" x="-22.86" y="160.02" smashed="yes" rot="R270">
<attribute name="NAME" x="-29.21" y="153.67" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="-19.05" y="161.29" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C5" gate="G$1" x="22.86" y="139.7" smashed="yes" rot="R270">
<attribute name="NAME" x="16.51" y="130.81" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="26.67" y="138.43" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C6" gate="G$1" x="43.18" y="147.32" smashed="yes" rot="R270">
<attribute name="NAME" x="36.83" y="140.97" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="49.53" y="143.51" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="IC3" gate="G$1" x="-45.72" y="88.9" smashed="yes">
<attribute name="NAME" x="-31.75" y="78.74" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="-39.37" y="93.98" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="C8" gate="G$1" x="-10.16" y="81.28" smashed="yes" rot="R270">
<attribute name="NAME" x="-13.97" y="74.93" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="-3.81" y="87.63" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="PS3" gate="G$1" x="10.16" y="17.78" smashed="yes">
<attribute name="NAME" x="21.59" y="10.16" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="16.51" y="22.86" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="C9" gate="G$1" x="-7.62" y="2.54" smashed="yes" rot="R90">
<attribute name="NAME" x="-1.27" y="8.89" size="1.778" layer="95" rot="R180" align="center-left"/>
<attribute name="VALUE" x="-11.43" y="-6.35" size="1.778" layer="96" rot="R90" align="center-left"/>
</instance>
<instance part="C10" gate="G$1" x="10.16" y="0" smashed="yes" rot="R90">
<attribute name="NAME" x="6.35" y="3.81" size="1.778" layer="95" rot="R180" align="center-left"/>
<attribute name="VALUE" x="16.51" y="11.43" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="IC4" gate="G$1" x="50.8" y="88.9" smashed="yes">
<attribute name="NAME" x="62.23" y="78.74" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="54.61" y="93.98" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="IC5" gate="G$1" x="-78.74" y="17.78" smashed="yes">
<attribute name="NAME" x="-69.85" y="10.16" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="-72.39" y="22.86" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="C11" gate="G$1" x="-88.9" y="15.24" smashed="yes" rot="R270">
<attribute name="NAME" x="-87.63" y="11.43" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="-95.25" y="16.51" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C12" gate="G$1" x="-45.72" y="12.7" smashed="yes" rot="R270">
<attribute name="NAME" x="-49.53" y="6.35" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="-39.37" y="19.05" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C13" gate="G$1" x="81.28" y="81.28" smashed="yes" rot="R270">
<attribute name="NAME" x="77.47" y="74.93" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="87.63" y="87.63" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C14" gate="G$1" x="38.1" y="81.28" smashed="yes" rot="R270">
<attribute name="NAME" x="41.91" y="74.93" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="31.75" y="82.55" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="IC6" gate="G$1" x="142.24" y="91.44" smashed="yes">
<attribute name="NAME" x="153.67" y="81.28" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="146.05" y="96.52" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="IC7" gate="G$1" x="99.06" y="17.78" smashed="yes">
<attribute name="NAME" x="110.49" y="5.08" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="102.87" y="22.86" size="1.778" layer="96" align="center-left"/>
</instance>
<instance part="C15" gate="G$1" x="81.28" y="15.24" smashed="yes" rot="R270">
<attribute name="NAME" x="85.09" y="8.89" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="74.93" y="16.51" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C16" gate="G$1" x="124.46" y="88.9" smashed="yes" rot="R270">
<attribute name="NAME" x="128.27" y="82.55" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="118.11" y="90.17" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C17" gate="G$1" x="129.54" y="15.24" smashed="yes" rot="R270">
<attribute name="NAME" x="125.73" y="8.89" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="135.89" y="21.59" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C18" gate="G$1" x="175.26" y="88.9" smashed="yes" rot="R270">
<attribute name="NAME" x="171.45" y="82.55" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="181.61" y="95.25" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C19" gate="G$1" x="-93.98" y="144.78" smashed="yes" rot="R270">
<attribute name="NAME" x="-90.17" y="138.43" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="-97.79" y="146.05" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="PS4" gate="G$1" x="-71.12" y="144.78" smashed="yes" rot="R90">
<attribute name="NAME" x="-63.5" y="151.13" size="1.778" layer="95" rot="R90" align="center-left"/>
<attribute name="VALUE" x="-76.2" y="151.13" size="1.778" layer="96" rot="R90" align="center-left"/>
</instance>
<instance part="C20" gate="G$1" x="-50.8" y="142.24" smashed="yes" rot="R270">
<attribute name="NAME" x="-57.15" y="135.89" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="-44.45" y="143.51" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="GND4" gate="1" x="-200.66" y="109.22" smashed="yes">
<attribute name="VALUE" x="-203.2" y="106.68" size="1.778" layer="96"/>
</instance>
<instance part="GND2" gate="1" x="-121.92" y="78.74" smashed="yes">
<attribute name="VALUE" x="-124.46" y="76.2" size="1.778" layer="96"/>
</instance>
<instance part="GND3" gate="1" x="-111.76" y="116.84" smashed="yes">
<attribute name="VALUE" x="-114.3" y="114.3" size="1.778" layer="96"/>
</instance>
<instance part="GND5" gate="1" x="-144.78" y="147.32" smashed="yes">
<attribute name="VALUE" x="-147.32" y="144.78" size="1.778" layer="96"/>
</instance>
<instance part="GND1" gate="1" x="-73.66" y="119.38" smashed="yes">
<attribute name="VALUE" x="-76.2" y="116.84" size="1.778" layer="96"/>
</instance>
<instance part="GND6" gate="1" x="15.24" y="129.54" smashed="yes">
<attribute name="VALUE" x="12.7" y="127" size="1.778" layer="96"/>
</instance>
<instance part="GND7" gate="1" x="43.18" y="129.54" smashed="yes">
<attribute name="VALUE" x="40.64" y="127" size="1.778" layer="96"/>
</instance>
<instance part="GND8" gate="1" x="22.86" y="121.92" smashed="yes">
<attribute name="VALUE" x="17.78" y="119.38" size="1.778" layer="96"/>
</instance>
<instance part="GND9" gate="1" x="20.32" y="154.94" smashed="yes">
<attribute name="VALUE" x="17.78" y="152.4" size="1.778" layer="96"/>
</instance>
<instance part="GND10" gate="1" x="-10.16" y="63.5" smashed="yes">
<attribute name="VALUE" x="-12.7" y="60.96" size="1.778" layer="96"/>
</instance>
<instance part="GND11" gate="1" x="-60.96" y="63.5" smashed="yes">
<attribute name="VALUE" x="-63.5" y="60.96" size="1.778" layer="96"/>
</instance>
<instance part="GND13" gate="1" x="10.16" y="-5.08" smashed="yes">
<attribute name="VALUE" x="7.62" y="-7.62" size="1.778" layer="96"/>
</instance>
<instance part="GND14" gate="1" x="38.1" y="12.7" smashed="yes">
<attribute name="VALUE" x="35.56" y="10.16" size="1.778" layer="96"/>
</instance>
<instance part="GND15" gate="1" x="-7.62" y="-5.08" smashed="yes">
<attribute name="VALUE" x="-10.16" y="-7.62" size="1.778" layer="96"/>
</instance>
<instance part="GND16" gate="1" x="-88.9" y="-2.54" smashed="yes">
<attribute name="VALUE" x="-91.44" y="-5.08" size="1.778" layer="96"/>
</instance>
<instance part="GND17" gate="1" x="-45.72" y="-5.08" smashed="yes">
<attribute name="VALUE" x="-48.26" y="-7.62" size="1.778" layer="96"/>
</instance>
<instance part="GND18" gate="1" x="-78.74" y="10.16" smashed="yes">
<attribute name="VALUE" x="-81.28" y="7.62" size="1.778" layer="96"/>
</instance>
<instance part="GND19" gate="1" x="38.1" y="60.96" smashed="yes">
<attribute name="VALUE" x="35.56" y="58.42" size="1.778" layer="96"/>
</instance>
<instance part="GND20" gate="1" x="81.28" y="60.96" smashed="yes">
<attribute name="VALUE" x="78.74" y="58.42" size="1.778" layer="96"/>
</instance>
<instance part="GND21" gate="1" x="45.72" y="83.82" smashed="yes">
<attribute name="VALUE" x="43.18" y="81.28" size="1.778" layer="96"/>
</instance>
<instance part="GND22" gate="1" x="137.16" y="83.82" smashed="yes">
<attribute name="VALUE" x="134.62" y="81.28" size="1.778" layer="96"/>
</instance>
<instance part="GND23" gate="1" x="124.46" y="68.58" smashed="yes">
<attribute name="VALUE" x="121.92" y="66.04" size="1.778" layer="96"/>
</instance>
<instance part="GND24" gate="1" x="175.26" y="71.12" smashed="yes">
<attribute name="VALUE" x="172.72" y="68.58" size="1.778" layer="96"/>
</instance>
<instance part="GND25" gate="1" x="93.98" y="10.16" smashed="yes">
<attribute name="VALUE" x="91.44" y="7.62" size="1.778" layer="96"/>
</instance>
<instance part="GND26" gate="1" x="129.54" y="-2.54" smashed="yes">
<attribute name="VALUE" x="127" y="-5.08" size="1.778" layer="96"/>
</instance>
<instance part="GND27" gate="1" x="81.28" y="-2.54" smashed="yes">
<attribute name="VALUE" x="78.74" y="-5.08" size="1.778" layer="96"/>
</instance>
<instance part="LED1" gate="G$1" x="-165.1" y="93.98" smashed="yes">
<attribute name="NAME" x="-152.4" y="102.87" size="1.778" layer="95"/>
<attribute name="VALUE" x="-152.4" y="100.33" size="1.778" layer="96"/>
</instance>
<instance part="LED2" gate="G$1" x="15.24" y="60.96" smashed="yes" rot="R90">
<attribute name="NAME" x="6.35" y="73.66" size="1.778" layer="95" rot="R90"/>
<attribute name="VALUE" x="8.89" y="73.66" size="1.778" layer="96" rot="R90"/>
</instance>
<instance part="LED3" gate="G$1" x="106.68" y="63.5" smashed="yes" rot="R90">
<attribute name="NAME" x="97.79" y="76.2" size="1.778" layer="95" rot="R90"/>
<attribute name="VALUE" x="100.33" y="76.2" size="1.778" layer="96" rot="R90"/>
</instance>
<instance part="GND28" gate="1" x="-165.1" y="88.9" smashed="yes">
<attribute name="VALUE" x="-167.64" y="86.36" size="1.778" layer="96"/>
</instance>
<instance part="GND29" gate="1" x="15.24" y="50.8" smashed="yes">
<attribute name="VALUE" x="12.7" y="48.26" size="1.778" layer="96"/>
</instance>
<instance part="GND30" gate="1" x="106.68" y="53.34" smashed="yes">
<attribute name="VALUE" x="104.14" y="50.8" size="1.778" layer="96"/>
</instance>
<instance part="GND12" gate="1" x="-53.34" y="83.82" smashed="yes">
<attribute name="VALUE" x="-55.88" y="81.28" size="1.778" layer="96"/>
</instance>
<instance part="GND31" gate="1" x="-132.08" y="116.84" smashed="yes" rot="R90">
<attribute name="VALUE" x="-129.54" y="114.3" size="1.778" layer="96" rot="R90"/>
</instance>
<instance part="R3" gate="G$1" x="-121.92" y="116.84" smashed="yes" rot="R90">
<attribute name="NAME" x="-124.46" y="124.46" size="1.778" layer="95" rot="R180" align="center-left"/>
<attribute name="VALUE" x="-118.11" y="107.95" size="1.778" layer="96" rot="R90" align="center-left"/>
</instance>
<instance part="R4" gate="G$1" x="-121.92" y="104.14" smashed="yes" rot="R270">
<attribute name="NAME" x="-127" y="96.52" size="1.778" layer="95" align="center-left"/>
<attribute name="VALUE" x="-116.84" y="104.14" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
<instance part="C7" gate="G$1" x="-60.96" y="81.28" smashed="yes" rot="R270">
<attribute name="NAME" x="-57.15" y="77.47" size="1.778" layer="95" rot="R270" align="center-left"/>
<attribute name="VALUE" x="-67.31" y="85.09" size="1.778" layer="96" rot="R270" align="center-left"/>
</instance>
</instances>
<busses>
</busses>
<nets>
<net name="VIN" class="0">
<segment>
<pinref part="IC2" gate="G$1" pin="!SHDN"/>
<pinref part="L1" gate="G$1" pin="1"/>
<wire x1="-193.04" y1="137.16" x2="-193.04" y2="119.38" width="0.1524" layer="91"/>
<junction x="-193.04" y="137.16"/>
<wire x1="-167.64" y1="119.38" x2="-193.04" y2="119.38" width="0.1524" layer="91"/>
<wire x1="-193.04" y1="137.16" x2="-200.66" y2="137.16" width="0.1524" layer="91"/>
<label x="-213.36" y="137.16" size="1.778" layer="95" rot="R180" xref="yes"/>
<wire x1="-200.66" y1="137.16" x2="-213.36" y2="137.16" width="0.1524" layer="91"/>
<pinref part="C1" gate="G$1" pin="1"/>
<wire x1="-200.66" y1="137.16" x2="-200.66" y2="132.08" width="0.1524" layer="91"/>
<pinref part="J1" gate="G$1" pin="1"/>
<wire x1="-165.1" y1="157.48" x2="-200.66" y2="157.48" width="0.1524" layer="91"/>
<wire x1="-200.66" y1="157.48" x2="-200.66" y2="137.16" width="0.1524" layer="91"/>
<junction x="-200.66" y="137.16"/>
<pinref part="IC2" gate="G$1" pin="VIN"/>
<wire x1="-167.64" y1="116.84" x2="-193.04" y2="116.84" width="0.1524" layer="91"/>
<wire x1="-193.04" y1="116.84" x2="-193.04" y2="119.38" width="0.1524" layer="91"/>
<junction x="-193.04" y="119.38"/>
</segment>
<segment>
<pinref part="LED1" gate="G$1" pin="A"/>
<wire x1="-149.86" y1="93.98" x2="-147.32" y2="93.98" width="0.1524" layer="91"/>
<label x="-147.32" y="93.98" size="1.778" layer="95" xref="yes"/>
</segment>
</net>
<net name="GND" class="0">
<segment>
<pinref part="C1" gate="G$1" pin="2"/>
<wire x1="-200.66" y1="119.38" x2="-200.66" y2="111.76" width="0.1524" layer="91"/>
<pinref part="GND4" gate="1" pin="GND"/>
</segment>
<segment>
<wire x1="-121.92" y1="86.36" x2="-121.92" y2="81.28" width="0.1524" layer="91"/>
<pinref part="GND2" gate="1" pin="GND"/>
<pinref part="R4" gate="G$1" pin="2"/>
</segment>
<segment>
<pinref part="C2" gate="G$1" pin="2"/>
<wire x1="-111.76" y1="121.92" x2="-111.76" y2="119.38" width="0.1524" layer="91"/>
<pinref part="GND3" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="J1" gate="G$1" pin="5"/>
<wire x1="-144.78" y1="154.94" x2="-144.78" y2="149.86" width="0.1524" layer="91"/>
<pinref part="GND5" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C19" gate="G$1" pin="2"/>
<wire x1="-93.98" y1="132.08" x2="-93.98" y2="127" width="0.1524" layer="91"/>
<wire x1="-93.98" y1="127" x2="-73.66" y2="127" width="0.1524" layer="91"/>
<pinref part="C20" gate="G$1" pin="2"/>
<wire x1="-73.66" y1="127" x2="-50.8" y2="127" width="0.1524" layer="91"/>
<wire x1="-50.8" y1="127" x2="-50.8" y2="129.54" width="0.1524" layer="91"/>
<junction x="-73.66" y="127"/>
<wire x1="-73.66" y1="127" x2="-73.66" y2="124.46" width="0.1524" layer="91"/>
<wire x1="-73.66" y1="121.92" x2="-73.66" y2="124.46" width="0.1524" layer="91"/>
<pinref part="GND1" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="PS2" gate="G$1" pin="GND"/>
<wire x1="15.24" y1="137.16" x2="15.24" y2="132.08" width="0.1524" layer="91"/>
<pinref part="GND6" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C6" gate="G$1" pin="2"/>
<wire x1="43.18" y1="134.62" x2="43.18" y2="132.08" width="0.1524" layer="91"/>
<pinref part="GND7" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C5" gate="G$1" pin="2"/>
<pinref part="GND8" gate="1" pin="GND"/>
<wire x1="22.86" y1="124.46" x2="22.86" y2="127" width="0.1524" layer="91"/>
</segment>
<segment>
<pinref part="C3" gate="G$1" pin="1"/>
<wire x1="30.48" y1="160.02" x2="30.48" y2="162.56" width="0.1524" layer="91"/>
<pinref part="PS1" gate="G$1" pin="+VOUT"/>
<wire x1="30.48" y1="162.56" x2="20.32" y2="162.56" width="0.1524" layer="91"/>
<wire x1="20.32" y1="162.56" x2="15.24" y2="162.56" width="0.1524" layer="91"/>
<wire x1="20.32" y1="162.56" x2="20.32" y2="157.48" width="0.1524" layer="91"/>
<junction x="20.32" y="162.56"/>
<pinref part="GND9" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C8" gate="G$1" pin="2"/>
<wire x1="-10.16" y1="68.58" x2="-10.16" y2="66.04" width="0.1524" layer="91"/>
<pinref part="GND10" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="GND11" gate="1" pin="GND"/>
<wire x1="-60.96" y1="66.04" x2="-60.96" y2="68.58" width="0.1524" layer="91"/>
<pinref part="C7" gate="G$1" pin="2"/>
</segment>
<segment>
<pinref part="C10" gate="G$1" pin="1"/>
<wire x1="10.16" y1="0" x2="10.16" y2="-2.54" width="0.1524" layer="91"/>
<pinref part="GND13" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="PS3" gate="G$1" pin="VSS"/>
<wire x1="38.1" y1="17.78" x2="38.1" y2="15.24" width="0.1524" layer="91"/>
<pinref part="GND14" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C9" gate="G$1" pin="1"/>
<wire x1="-7.62" y1="2.54" x2="-7.62" y2="-2.54" width="0.1524" layer="91"/>
<pinref part="GND15" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C11" gate="G$1" pin="2"/>
<wire x1="-88.9" y1="2.54" x2="-88.9" y2="0" width="0.1524" layer="91"/>
<pinref part="GND16" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C12" gate="G$1" pin="2"/>
<wire x1="-45.72" y1="0" x2="-45.72" y2="-2.54" width="0.1524" layer="91"/>
<pinref part="GND17" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="IC5" gate="G$1" pin="GND"/>
<wire x1="-78.74" y1="15.24" x2="-78.74" y2="12.7" width="0.1524" layer="91"/>
<pinref part="GND18" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C14" gate="G$1" pin="2"/>
<wire x1="38.1" y1="68.58" x2="38.1" y2="63.5" width="0.1524" layer="91"/>
<pinref part="GND19" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C13" gate="G$1" pin="2"/>
<pinref part="GND20" gate="1" pin="GND"/>
<wire x1="81.28" y1="63.5" x2="81.28" y2="68.58" width="0.1524" layer="91"/>
</segment>
<segment>
<pinref part="IC4" gate="G$1" pin="GND"/>
<wire x1="50.8" y1="86.36" x2="45.72" y2="86.36" width="0.1524" layer="91"/>
<pinref part="GND21" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C16" gate="G$1" pin="2"/>
<wire x1="124.46" y1="76.2" x2="124.46" y2="71.12" width="0.1524" layer="91"/>
<pinref part="GND23" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C18" gate="G$1" pin="2"/>
<wire x1="175.26" y1="76.2" x2="175.26" y2="73.66" width="0.1524" layer="91"/>
<pinref part="GND24" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="IC7" gate="G$1" pin="GND"/>
<wire x1="99.06" y1="15.24" x2="93.98" y2="15.24" width="0.1524" layer="91"/>
<wire x1="93.98" y1="15.24" x2="93.98" y2="12.7" width="0.1524" layer="91"/>
<pinref part="GND25" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C17" gate="G$1" pin="2"/>
<wire x1="129.54" y1="2.54" x2="129.54" y2="0" width="0.1524" layer="91"/>
<pinref part="GND26" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="C15" gate="G$1" pin="2"/>
<wire x1="81.28" y1="2.54" x2="81.28" y2="0" width="0.1524" layer="91"/>
<pinref part="GND27" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="LED1" gate="G$1" pin="K"/>
<wire x1="-165.1" y1="93.98" x2="-165.1" y2="91.44" width="0.1524" layer="91"/>
<pinref part="GND28" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="LED2" gate="G$1" pin="K"/>
<wire x1="15.24" y1="60.96" x2="15.24" y2="53.34" width="0.1524" layer="91"/>
<pinref part="GND29" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="LED3" gate="G$1" pin="K"/>
<wire x1="106.68" y1="63.5" x2="106.68" y2="55.88" width="0.1524" layer="91"/>
<pinref part="GND30" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="IC3" gate="G$1" pin="GND"/>
<wire x1="-45.72" y1="86.36" x2="-53.34" y2="86.36" width="0.1524" layer="91"/>
<pinref part="GND12" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="IC2" gate="G$1" pin="GND"/>
<wire x1="-139.7" y1="116.84" x2="-134.62" y2="116.84" width="0.1524" layer="91"/>
<pinref part="GND31" gate="1" pin="GND"/>
</segment>
<segment>
<pinref part="IC6" gate="G$1" pin="GND"/>
<wire x1="142.24" y1="88.9" x2="137.16" y2="88.9" width="0.1524" layer="91"/>
<pinref part="GND22" gate="1" pin="GND"/>
<wire x1="137.16" y1="88.9" x2="137.16" y2="86.36" width="0.1524" layer="91"/>
</segment>
</net>
<net name="N$8" class="0">
<segment>
<pinref part="L1" gate="G$1" pin="2"/>
<pinref part="D1" gate="G$1" pin="A_1"/>
<wire x1="-172.72" y1="137.16" x2="-167.64" y2="137.16" width="0.1524" layer="91"/>
<wire x1="-167.64" y1="137.16" x2="-160.02" y2="137.16" width="0.1524" layer="91"/>
<junction x="-167.64" y="137.16"/>
<wire x1="-167.64" y1="137.16" x2="-167.64" y2="127" width="0.1524" layer="91"/>
<wire x1="-167.64" y1="127" x2="-139.7" y2="127" width="0.1524" layer="91"/>
<pinref part="IC2" gate="G$1" pin="SW"/>
<wire x1="-139.7" y1="127" x2="-139.7" y2="119.38" width="0.1524" layer="91"/>
</segment>
</net>
<net name="IN" class="0">
<segment>
<pinref part="PS4" gate="G$1" pin="1"/>
<pinref part="C19" gate="G$1" pin="1"/>
<wire x1="-71.12" y1="144.78" x2="-93.98" y2="144.78" width="0.1524" layer="91"/>
<pinref part="C2" gate="G$1" pin="1"/>
<wire x1="-111.76" y1="144.78" x2="-111.76" y2="134.62" width="0.1524" layer="91"/>
<wire x1="-111.76" y1="144.78" x2="-121.92" y2="144.78" width="0.1524" layer="91"/>
<wire x1="-121.92" y1="132.08" x2="-121.92" y2="134.62" width="0.1524" layer="91"/>
<pinref part="R3" gate="G$1" pin="2"/>
<wire x1="-121.92" y1="134.62" x2="-121.92" y2="137.16" width="0.1524" layer="91"/>
<pinref part="D1" gate="G$1" pin="K"/>
<wire x1="-137.16" y1="137.16" x2="-121.92" y2="137.16" width="0.1524" layer="91"/>
<wire x1="-121.92" y1="144.78" x2="-121.92" y2="137.16" width="0.1524" layer="91"/>
<junction x="-121.92" y="137.16"/>
<wire x1="-93.98" y1="144.78" x2="-111.76" y2="144.78" width="0.1524" layer="91"/>
<junction x="-93.98" y="144.78"/>
<junction x="-111.76" y="144.78"/>
</segment>
</net>
<net name="-6.5V" class="0">
<segment>
<pinref part="C4" gate="G$1" pin="2"/>
<wire x1="-22.86" y1="147.32" x2="-15.24" y2="147.32" width="0.1524" layer="91"/>
<wire x1="-15.24" y1="147.32" x2="-15.24" y2="149.86" width="0.1524" layer="91"/>
<pinref part="PS1" gate="G$1" pin="GND"/>
<wire x1="-15.24" y1="149.86" x2="15.24" y2="149.86" width="0.1524" layer="91"/>
<wire x1="15.24" y1="149.86" x2="15.24" y2="157.48" width="0.1524" layer="91"/>
<pinref part="C3" gate="G$1" pin="2"/>
<wire x1="30.48" y1="147.32" x2="17.78" y2="147.32" width="0.1524" layer="91"/>
<wire x1="17.78" y1="147.32" x2="17.78" y2="149.86" width="0.1524" layer="91"/>
<wire x1="17.78" y1="149.86" x2="15.24" y2="149.86" width="0.1524" layer="91"/>
<junction x="15.24" y="149.86"/>
<pinref part="C6" gate="G$1" pin="1"/>
<wire x1="30.48" y1="147.32" x2="43.18" y2="147.32" width="0.1524" layer="91"/>
<junction x="30.48" y="147.32"/>
<wire x1="43.18" y1="147.32" x2="53.34" y2="147.32" width="0.1524" layer="91"/>
<junction x="43.18" y="147.32"/>
<label x="53.34" y="147.32" size="1.778" layer="95" xref="yes"/>
</segment>
<segment>
<pinref part="PS3" gate="G$1" pin="-VIN"/>
<wire x1="10.16" y1="15.24" x2="5.08" y2="15.24" width="0.1524" layer="91"/>
<label x="5.08" y="15.24" size="1.778" layer="95" rot="R180" xref="yes"/>
<pinref part="C10" gate="G$1" pin="2"/>
<wire x1="10.16" y1="12.7" x2="10.16" y2="15.24" width="0.1524" layer="91"/>
<junction x="10.16" y="15.24"/>
</segment>
<segment>
<pinref part="IC5" gate="G$1" pin="-VIN"/>
<wire x1="-48.26" y1="17.78" x2="-45.72" y2="17.78" width="0.1524" layer="91"/>
<pinref part="C12" gate="G$1" pin="1"/>
<wire x1="-45.72" y1="17.78" x2="-45.72" y2="12.7" width="0.1524" layer="91"/>
<junction x="-45.72" y="17.78"/>
<wire x1="-45.72" y1="17.78" x2="-45.72" y2="20.32" width="0.1524" layer="91"/>
<label x="-45.72" y="20.32" size="1.778" layer="95" rot="R90" xref="yes"/>
</segment>
</net>
<net name="6.5V" class="0">
<segment>
<pinref part="IC3" gate="G$1" pin="VIN"/>
<wire x1="-45.72" y1="88.9" x2="-60.96" y2="88.9" width="0.1524" layer="91"/>
<label x="-73.66" y="88.9" size="1.778" layer="95" rot="R180" xref="yes"/>
<pinref part="C7" gate="G$1" pin="1"/>
<wire x1="-60.96" y1="81.28" x2="-60.96" y2="88.9" width="0.1524" layer="91"/>
<wire x1="-73.66" y1="88.9" x2="-60.96" y2="88.9" width="0.1524" layer="91"/>
<junction x="-60.96" y="88.9"/>
</segment>
<segment>
<pinref part="IC3" gate="G$1" pin="CONTROL"/>
<wire x1="-45.72" y1="83.82" x2="-45.72" y2="76.2" width="0.1524" layer="91"/>
<label x="-45.72" y="76.2" size="1.778" layer="95" rot="R270" xref="yes"/>
</segment>
<segment>
<pinref part="C5" gate="G$1" pin="1"/>
<wire x1="22.86" y1="139.7" x2="22.86" y2="142.24" width="0.1524" layer="91"/>
<pinref part="PS2" gate="G$1" pin="+VOUT"/>
<wire x1="15.24" y1="142.24" x2="22.86" y2="142.24" width="0.1524" layer="91"/>
<junction x="22.86" y="142.24"/>
<wire x1="22.86" y1="142.24" x2="27.94" y2="142.24" width="0.1524" layer="91"/>
<label x="27.94" y="142.24" size="1.778" layer="95" xref="yes"/>
</segment>
</net>
<net name="5V" class="0">
<segment>
<pinref part="C8" gate="G$1" pin="1"/>
<wire x1="-10.16" y1="81.28" x2="-10.16" y2="88.9" width="0.1524" layer="91"/>
<pinref part="IC3" gate="G$1" pin="VOUT"/>
<wire x1="-10.16" y1="88.9" x2="-12.7" y2="88.9" width="0.1524" layer="91"/>
<wire x1="-10.16" y1="88.9" x2="0" y2="88.9" width="0.1524" layer="91"/>
<junction x="-10.16" y="88.9"/>
<label x="0" y="88.9" size="1.778" layer="95" xref="yes"/>
</segment>
<segment>
<pinref part="C14" gate="G$1" pin="1"/>
<wire x1="38.1" y1="81.28" x2="38.1" y2="88.9" width="0.1524" layer="91"/>
<pinref part="IC4" gate="G$1" pin="VIN"/>
<wire x1="38.1" y1="88.9" x2="50.8" y2="88.9" width="0.1524" layer="91"/>
<wire x1="38.1" y1="88.9" x2="33.02" y2="88.9" width="0.1524" layer="91"/>
<junction x="38.1" y="88.9"/>
<label x="33.02" y="88.9" size="1.778" layer="95" rot="R180" xref="yes"/>
</segment>
<segment>
<pinref part="IC4" gate="G$1" pin="EN"/>
<wire x1="50.8" y1="83.82" x2="50.8" y2="76.2" width="0.1524" layer="91"/>
<label x="50.8" y="76.2" size="1.778" layer="95" rot="R270" xref="yes"/>
</segment>
<segment>
<pinref part="LED2" gate="G$1" pin="A"/>
<wire x1="15.24" y1="76.2" x2="15.24" y2="81.28" width="0.1524" layer="91"/>
<label x="15.24" y="81.28" size="1.778" layer="95" rot="R90" xref="yes"/>
</segment>
</net>
<net name="-5V" class="0">
<segment>
<pinref part="PS3" gate="G$1" pin="-VOUT"/>
<wire x1="10.16" y1="17.78" x2="-7.62" y2="17.78" width="0.1524" layer="91"/>
<pinref part="C9" gate="G$1" pin="2"/>
<wire x1="-7.62" y1="17.78" x2="-7.62" y2="15.24" width="0.1524" layer="91"/>
<wire x1="-7.62" y1="17.78" x2="-7.62" y2="20.32" width="0.1524" layer="91"/>
<junction x="-7.62" y="17.78"/>
<label x="-7.62" y="20.32" size="1.778" layer="95" rot="R90" xref="yes"/>
</segment>
</net>
<net name="-2.5V" class="0">
<segment>
<pinref part="IC5" gate="G$1" pin="-VOUT"/>
<wire x1="-78.74" y1="17.78" x2="-88.9" y2="17.78" width="0.1524" layer="91"/>
<pinref part="C11" gate="G$1" pin="1"/>
<wire x1="-88.9" y1="15.24" x2="-88.9" y2="17.78" width="0.1524" layer="91"/>
<wire x1="-88.9" y1="17.78" x2="-96.52" y2="17.78" width="0.1524" layer="91"/>
<junction x="-88.9" y="17.78"/>
<label x="-96.52" y="17.78" size="1.778" layer="95" rot="R180" xref="yes"/>
</segment>
</net>
<net name="2.5V" class="0">
<segment>
<pinref part="C13" gate="G$1" pin="1"/>
<wire x1="81.28" y1="81.28" x2="81.28" y2="86.36" width="0.1524" layer="91"/>
<pinref part="IC4" gate="G$1" pin="VOUT"/>
<wire x1="81.28" y1="86.36" x2="78.74" y2="86.36" width="0.1524" layer="91"/>
<wire x1="81.28" y1="86.36" x2="88.9" y2="86.36" width="0.1524" layer="91"/>
<junction x="81.28" y="86.36"/>
<label x="88.9" y="86.36" size="1.778" layer="95" xref="yes"/>
</segment>
<segment>
<pinref part="C16" gate="G$1" pin="1"/>
<wire x1="124.46" y1="88.9" x2="124.46" y2="91.44" width="0.1524" layer="91"/>
<pinref part="IC6" gate="G$1" pin="IN"/>
<wire x1="124.46" y1="91.44" x2="142.24" y2="91.44" width="0.1524" layer="91"/>
<junction x="124.46" y="91.44"/>
<wire x1="119.38" y1="91.44" x2="124.46" y2="91.44" width="0.1524" layer="91"/>
<label x="119.38" y="91.44" size="1.778" layer="95" rot="R180" xref="yes"/>
</segment>
<segment>
<pinref part="IC6" gate="G$1" pin="EN"/>
<wire x1="142.24" y1="86.36" x2="142.24" y2="71.12" width="0.1524" layer="91"/>
<label x="142.24" y="71.12" size="1.778" layer="95" rot="R270" xref="yes"/>
</segment>
<segment>
<pinref part="C15" gate="G$1" pin="1"/>
<wire x1="81.28" y1="15.24" x2="81.28" y2="17.78" width="0.1524" layer="91"/>
<pinref part="IC7" gate="G$1" pin="IN"/>
<wire x1="81.28" y1="17.78" x2="99.06" y2="17.78" width="0.1524" layer="91"/>
<wire x1="81.28" y1="17.78" x2="73.66" y2="17.78" width="0.1524" layer="91"/>
<junction x="81.28" y="17.78"/>
<label x="73.66" y="17.78" size="1.778" layer="95" rot="R180" xref="yes"/>
</segment>
<segment>
<pinref part="IC7" gate="G$1" pin="EN"/>
<wire x1="99.06" y1="12.7" x2="99.06" y2="7.62" width="0.1524" layer="91"/>
<label x="99.06" y="7.62" size="1.778" layer="95" rot="R270" xref="yes"/>
</segment>
<segment>
<pinref part="LED3" gate="G$1" pin="A"/>
<wire x1="106.68" y1="78.74" x2="106.68" y2="83.82" width="0.1524" layer="91"/>
<label x="106.68" y="83.82" size="1.778" layer="95" rot="R90" xref="yes"/>
</segment>
</net>
<net name="1.65V" class="0">
<segment>
<pinref part="IC6" gate="G$1" pin="OUT"/>
<pinref part="C18" gate="G$1" pin="1"/>
<wire x1="167.64" y1="88.9" x2="175.26" y2="88.9" width="0.1524" layer="91"/>
<wire x1="175.26" y1="88.9" x2="185.42" y2="88.9" width="0.1524" layer="91"/>
<junction x="175.26" y="88.9"/>
<label x="185.42" y="88.9" size="1.778" layer="95" xref="yes"/>
</segment>
</net>
<net name="1.5V" class="0">
<segment>
<pinref part="IC7" gate="G$1" pin="OUT"/>
<pinref part="C17" gate="G$1" pin="1"/>
<wire x1="124.46" y1="15.24" x2="129.54" y2="15.24" width="0.1524" layer="91"/>
<wire x1="129.54" y1="15.24" x2="142.24" y2="15.24" width="0.1524" layer="91"/>
<junction x="129.54" y="15.24"/>
<wire x1="142.24" y1="15.24" x2="142.24" y2="17.78" width="0.1524" layer="91"/>
<label x="142.24" y="17.78" size="1.778" layer="95" rot="R90" xref="yes"/>
</segment>
</net>
<net name="N$2" class="0">
<segment>
<pinref part="R3" gate="G$1" pin="1"/>
<wire x1="-121.92" y1="121.92" x2="-121.92" y2="116.84" width="0.1524" layer="91"/>
<wire x1="-121.92" y1="116.84" x2="-121.92" y2="114.3" width="0.1524" layer="91"/>
<pinref part="R4" gate="G$1" pin="1"/>
<pinref part="IC2" gate="G$1" pin="FB"/>
<wire x1="-121.92" y1="114.3" x2="-121.92" y2="104.14" width="0.1524" layer="91"/>
<wire x1="-139.7" y1="114.3" x2="-121.92" y2="114.3" width="0.1524" layer="91"/>
<junction x="-121.92" y="114.3"/>
</segment>
</net>
<net name="N$7" class="0">
<segment>
<pinref part="PS2" gate="G$1" pin="+VIN"/>
<wire x1="-38.1" y1="144.78" x2="-38.1" y2="142.24" width="0.1524" layer="91"/>
<wire x1="-38.1" y1="142.24" x2="-15.24" y2="142.24" width="0.1524" layer="91"/>
<pinref part="C20" gate="G$1" pin="1"/>
<wire x1="-50.8" y1="144.78" x2="-50.8" y2="142.24" width="0.1524" layer="91"/>
<pinref part="PS4" gate="G$1" pin="2"/>
<wire x1="-68.58" y1="144.78" x2="-50.8" y2="144.78" width="0.1524" layer="91"/>
<wire x1="-50.8" y1="144.78" x2="-50.8" y2="162.56" width="0.1524" layer="91"/>
<wire x1="-38.1" y1="144.78" x2="-50.8" y2="144.78" width="0.1524" layer="91"/>
<junction x="-50.8" y="144.78"/>
<pinref part="PS1" gate="G$1" pin="+VIN"/>
<wire x1="-15.24" y1="162.56" x2="-22.86" y2="162.56" width="0.1524" layer="91"/>
<pinref part="C4" gate="G$1" pin="1"/>
<wire x1="-22.86" y1="160.02" x2="-22.86" y2="162.56" width="0.1524" layer="91"/>
<wire x1="-50.8" y1="162.56" x2="-22.86" y2="162.56" width="0.1524" layer="91"/>
<junction x="-22.86" y="162.56"/>
</segment>
</net>
</nets>
</sheet>
</sheets>
</schematic>
</drawing>
<compatibility>
<note version="8.2" severity="warning">
Since Version 8.2, EAGLE supports online libraries. The ids
of those online libraries will not be understood (or retained)
with this version.
</note>
<note version="8.3" severity="warning">
Since Version 8.3, EAGLE supports URNs for individual library
assets (packages, symbols, and devices). The URNs of those assets
will not be understood (or retained) with this version.
</note>
</compatibility>
</eagle>
