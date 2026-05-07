# preview-screenshot-demo-generator

プレビュー・スクショ・デモ生成 は、Animation、Effect、Timeline、UIスクリーンショット、GIF、SampleScene、デモ生成をまとめる。

## 何を解決するか

素材や機能の見え方を共有するためのスクショ、GIF、デモScene作成が手作業になりやすい。

## 差別化

プレビュー確認から共有用成果物までUnity内で生成する。

## 公開先

- GitHub Release / BOOTH

## 現在の到達点

- core / validators / report / review-model / CLI に責務を分割済み
- Unity EditorWindow + package の最小実装または配布用骨格を同梱済み
- 代表シナリオ `samples/representative-suite.json` で正常系、必須項目不足、warning、混在バッチを自動検証済み
- 厳格 QCDS は Quality、Cost、Delivery、Satisfaction の全観点 S+ で評価済み
- docs ZIP は `dist/preview-screenshot-demo-generator-docs.zip`

## 主要コマンド

```powershell
npm test
npm start
```

## 重要ドキュメント

- [要件定義](docs/requirements.md)
- [仕様](docs/specification.md)
- [設計](docs/design.md)
- [手動テスト](docs/manual-test.md)
- [厳格手動テスト追補](docs/strict-manual-test-addendum.md)
- [QCDS評価](docs/qcds-evaluation.md)
- [厳格QCDS metrics](docs/qcds-strict-metrics.json)
- [トレーサビリティ](docs/traceability-matrix.md)

## 参照したアイデアパック

- created_idea: `D:\AI\UnityEditor\created_idea_004_preview-screenshot-demo-generator`
- idea ZIP: `D:\AI\UnityEditor\created_idea_004_preview-screenshot-demo-generator\idea_004_preview-screenshot-demo-generator.zip`
- PICKUP rank: 23
- Domain: UnityEditor
